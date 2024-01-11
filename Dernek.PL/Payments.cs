using Dernek.Application.Repositories.Member;
using Dernek.Application.Repositories.MembershipFee;
using Dernek.Application.Repositories.Payment;
using Dernek.Core.Entities;
using Dernek.Core.Enums;
using Dernek.PL.ViewModels;
using System.Data;

namespace Dernek.PL
{
    public partial class Payments : UserControl
    {
        private readonly IMemberReadRepository _memberReadRepository;
        private readonly IMembershipFeeReadRepository _membershipFeeReadRepository;
        private readonly IPaymentReadRepository _paymentReadRepository;
        private readonly IPaymentWriteRepository _paymentWriteRepository;

        private bool _addPaymentState = false;
        public Payments(IMemberReadRepository memberReadRepository, IMembershipFeeReadRepository membershipFeeReadRepository, IPaymentReadRepository paymentReadRepository, IPaymentWriteRepository paymentWriteRepository)
        {
            _membershipFeeReadRepository = membershipFeeReadRepository;
            _memberReadRepository = memberReadRepository;
            _paymentReadRepository = paymentReadRepository;
            _paymentWriteRepository = paymentWriteRepository;
            InitializeComponent();
        }

        private async void LoadData()
        {
            try
            {

                List<PaymentEntity> payments = _paymentReadRepository.GetAll().ToList();
                List<PaymentInfoViewModel> paymentInfos = payments.Select(payment => new PaymentInfoViewModel
                {
                    PaymentId = payment.Id,
                    MemberId = payment.Member.Id,
                    MemberFullName = $"{payment.Member.Name} {payment.Member.Surname}",
                    Month = payment.MembershipFee.Month.ToString(),
                    MembershipFee = $"{payment.MembershipFee.Fee}₺",
                    PaymentDate = payment.PaymentDate.ToString("dd MMM yyyy")
                }).ToList();
                dataGridView1.DataSource = paymentInfos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private MembershipFeeEntity? GetSelectedMonth(string month = "Ocak") => _membershipFeeReadRepository.GetMonth(month);
        private void Payments_Load(object sender, EventArgs e)
        {
            List<string> months = Enum.GetNames(typeof(Month)).ToList();
            var members = _memberReadRepository.GetAll().Select(m => new { FullName = $"{m.Name} {m.Surname}", m.Id }).ToList();

            monthsComboBox.DataSource = months;
            membersComboBox.DataSource = members;
            membersComboBox.DisplayMember = "FullName";
            membersComboBox.ValueMember = "Id";
            membersComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            membersComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            LoadData();
            dataGridView1.ReadOnly = true;

            var paymentIdColumn = dataGridView1.Columns["PaymentId"].Visible = false;
            var memberIdColumn = dataGridView1.Columns["MemberId"];
            var memberFullNameColumn = dataGridView1.Columns["MemberFullName"];
            var monthColumn = dataGridView1.Columns["Month"];
            var membershipFeeColumn = dataGridView1.Columns["MembershipFee"];
            var paymentDateColumn = dataGridView1.Columns["PaymentDate"];

            memberIdColumn.HeaderText = "Üye Tc Kimlik No";
            memberFullNameColumn.HeaderText = "Üye Ad Soyad";
            monthColumn.HeaderText = "Ödeme Yapılan Ay";
            membershipFeeColumn.HeaderText = "Aidat Ücreti";
            paymentDateColumn.HeaderText = "Ödeme Tarihi";


            ToggleInputs(false);
            MembershipFeeEntity? firstMonth = GetSelectedMonth();
            feeLabel.Text = $"{firstMonth?.Fee}";
            monthsComboBox.SelectedIndex = 0;
            formSubTitleLabel.Visible = false;
            buttonsPanel.Visible = false;

        }


        private void MonthsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MembershipFeeEntity? selectedMonth = GetSelectedMonth(monthsComboBox.Text);
            feeLabel.Text = $"{selectedMonth?.Fee}₺";

        }

        private void ToggleInputs(bool active)
        {
            if (active)
            {
                membersComboBox.Enabled = true;
                monthsComboBox.Enabled = true;
                datePickerInput.Enabled = true;
                buttonsPanel.Visible = true;
            }
            else
            {
                membersComboBox.Enabled = false;
                monthsComboBox.Enabled = false;
                datePickerInput.Enabled = false;
                buttonsPanel.Visible = false;
            }
        }

        private void ToggleForm()
        {
            if (_addPaymentState)
            {
                formSubTitleLabel.Text = "Aşağıdaki üye listesinden üyeyi arayıp seçerek ödeme oluşturabilirsiniz.";
                formSubTitleLabel.Visible = true;
                updatePayment.Visible = false;
                deletePayment.Visible = false;
                addPayment.Visible = true;
            }
            else
            {
                formSubTitleLabel.Text = "Yandaki tablodan ödeme kaydını seçerek güncelleme yapabilirsiniz.\nÖdeme güncellerken üyeyi değiştiremezsiniz, bunun yerine hatalı ödemeyi silip yeni ödeme oluşturabilirsiniz.";
                formSubTitleLabel.Visible = true;
                updatePayment.Visible = true;
                deletePayment.Visible = true;
                addPayment.Visible = false;
            }
        }

        private void ClearInputs()
        {
            membersComboBox.SelectedIndex = 0;
            monthsComboBox.SelectedIndex = 0;
            datePickerInput.Value = DateTime.Now;
        }

        private void CreatePaymentToggleButton_Click(object sender, EventArgs e)
        {
            ClearInputs();
            ToggleInputs(true);
            _addPaymentState = true;
            ToggleForm();

        }

        private void UpdatePaymentToggleButton_Click(object sender, EventArgs e)
        {
            ToggleInputs(true);
            membersComboBox.Enabled = false;
            _addPaymentState = false;
            ToggleForm();
        }

        private async void CreatePayment(DateTime paymentDate, MemberEntity selectedMember, MembershipFeeEntity selectedMonth)
        {
            try
            {
                PaymentEntity newPayment = new()
                {
                    Id = Guid.NewGuid().ToString(),
                    PaymentDate = paymentDate,
                    Member = selectedMember,
                    MembershipFee = selectedMonth
                };

                await _paymentWriteRepository.AddAsync(newPayment);
                await _paymentWriteRepository.SaveAsync();

            }
            catch (Exception)
            {
                throw new Exception("Bir hata oluştu, lütfen tekrar deneyin.");
            }
            finally
            {
                LoadData();
            }

        }
        private async void AddPayment_Click(object sender, EventArgs e)
        {

            MembershipFeeEntity selectedMonth = _membershipFeeReadRepository.GetMonth(monthsComboBox.Text);
            MemberEntity selectedMember = await _memberReadRepository.GetByIdAsync(membersComboBox.SelectedValue.ToString());
            DateTime paymentDate = datePickerInput.Value;

            var paymentIsExists = _paymentReadRepository.GetWhere(p => p.MembershipFee == selectedMonth && p.Member == selectedMember).FirstOrDefault();

            if (paymentIsExists != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bu üyeye ve aya ait bir ödeme mevcut, aynı ödemeyi tekrar oluşturmak istediğinize emin misiniz ?", null, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    CreatePayment(paymentDate, selectedMember, selectedMonth);
                }
            }
            else
            {
                CreatePayment(paymentDate, selectedMember, selectedMonth);
            }
        }

        private void DataGridView1_SelectRow(object sender, DataGridViewCellEventArgs e)
        {
            // Bu fonksiyon hem hücre içeriğine tıklandığında hemde satır seçildiğinde içeriği soldaki form kısmına atıyor.

            var rowIndex = e.RowIndex;
            if (rowIndex >= 0 && !_addPaymentState)
            {
                if (dataGridView1.Rows[rowIndex].DataBoundItem is PaymentInfoViewModel payment)
                {
                    membersComboBox.SelectedValue = payment.MemberId;
                    monthsComboBox.Text = payment.Month;
                    datePickerInput.Value = DateTime.Parse(payment.PaymentDate);
                }

            }

        }

        private async void UpdatePaymentButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
