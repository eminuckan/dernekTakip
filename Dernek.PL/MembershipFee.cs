using Dernek.Application.Repositories.MembershipFee;
using Dernek.Core.Entities;
using Dernek.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dernek.PL
{
    public partial class MembershipFee : UserControl
    {
        private readonly IMembershipFeeReadRepository _membershipFeeReadRepository;
        private readonly IMembershipFeeWriteRepository _membershipFeeWriteRepository;
        public MembershipFee(IMembershipFeeWriteRepository membershipFeeWriteRepository, IMembershipFeeReadRepository membershipFeeReadRepository)
        {
            _membershipFeeReadRepository = membershipFeeReadRepository;
            _membershipFeeWriteRepository = membershipFeeWriteRepository;
            InitializeComponent();

        }

        public void LoadData()
        {
            var fees = _membershipFeeReadRepository.GetAll().OrderBy(m => m.Month).ToList();
            dataGridView1.DataSource = fees;

        }

        private void MembershipFee_Load(object sender, EventArgs e)
        {

            LoadData();
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Month"].HeaderText = "Ay";
            dataGridView1.Columns["Payments"].Visible = false;
            dataGridView1.Columns["CreatedAt"].HeaderText = "Oluşturulma Tarihi";
            dataGridView1.ReadOnly = true;

            List<string> months = Enum.GetNames(typeof(Month)).ToList();
            monthsComboBox.DataSource = months;
            monthsComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            monthsComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private async void UpdateFee_Click(object sender, EventArgs e)
        {
            decimal fee = Convert.ToDecimal(feeInput.Text);
            Month selectedMonth = (Month)Enum.Parse(typeof(Month), monthsComboBox.Text);
            try
            {
                MembershipFeeEntity membershipFee = _membershipFeeReadRepository.GetWhere(m => m.Month == selectedMonth).FirstOrDefault();
                membershipFee.Fee = fee;
                _membershipFeeWriteRepository.Update(membershipFee);
                await _membershipFeeWriteRepository.SaveAsync();
            }
            catch (Exception)
            {
                throw new Exception("Bir sorun oluştu lütfen tekrar deneyin.");
            }
            finally
            {
                LoadData();
            }
            
            
        }
    }
}
