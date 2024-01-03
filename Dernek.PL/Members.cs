using Dernek.Application.Repositories.Member;
using Dernek.Core.Entities;
using Dernek.Core.Enums;
using Dernek.PL.Helper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dernek.PL
{
    public partial class Members : UserControl
    {
        private readonly IMemberWriteRepository _memberWriteRepository;
        private readonly IMemberReadRepository _memberReadRepository;

        private bool _addMemberState = false;
        public Members(IMemberWriteRepository memberWriteRepository,
            IMemberReadRepository memberReadRepository)
        {
            _memberWriteRepository = memberWriteRepository;
            _memberReadRepository = memberReadRepository;
            InitializeComponent();
        }

        private void LoadData()
        {
            var members = _memberReadRepository.GetAll();
            dataGridView1.DataSource = members.OrderByDescending(m => m.CreatedAt).ToList();
            dataGridView1.Columns["Id"].HeaderText = "TC Kimlik Numarası";
            dataGridView1.Columns["Id"].DisplayIndex = 0;
            dataGridView1.Columns["Name"].HeaderText = "Ad";
            dataGridView1.Columns["Name"].DisplayIndex = 1;
            dataGridView1.Columns["Surname"].HeaderText = "Soyad";
            dataGridView1.Columns["Surname"].DisplayIndex = 2;
            dataGridView1.Columns["Email"].HeaderText = "E Posta";
            dataGridView1.Columns["Email"].DisplayIndex = 3;
            dataGridView1.Columns["City"].HeaderText = "Şehir";
            dataGridView1.Columns["City"].DisplayIndex = 4;
            dataGridView1.Columns["BloodType"].HeaderText = "Kan Grubu";
            dataGridView1.Columns["BloodType"].DisplayIndex = 5;
            dataGridView1.Columns["IsActive"].Visible = false;
            dataGridView1.Columns["CreatedAt"].HeaderText = "Oluşturulma Tarihi";
            dataGridView1.Columns["CreatedAt"].DisplayIndex = 7;

        }

        private void ToggleInputs(bool active)
        {
            if (active)
            {
                nameInput.Enabled = true;
                surnameInput.Enabled = true;
                idInput.Enabled = true;
                mailInput.Enabled = true;
                cityInput.Enabled = true;
                bloodTypeInput.Enabled = true;
                isActive.Enabled = true;
            }
            else
            {
                nameInput.Enabled = false;
                surnameInput.Enabled = false;
                idInput.Enabled = false;
                mailInput.Enabled = false;
                cityInput.Enabled = false;
                bloodTypeInput.Enabled = false;
                isActive.Enabled = false;
            }
        }

        private void Members_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn uyelikDurumuKolonu = new DataGridViewTextBoxColumn
            {
                Name = "uyelikDurumu",
                HeaderText = "Üyelik Durumu Gösterim",
                ReadOnly = true,
            };
            dataGridView1.Columns.Add(uyelikDurumuKolonu);

            cityInput.DataSource = Enum.GetValues(typeof(City));
            bloodTypeInput.DataSource = Enum.GetValues(typeof(BloodType));
            dataGridView1.ReadOnly = true;
            addButton.Visible = false;
            updateButton.Visible = false;
            deleteButton.Visible = false;
            formSubTitleLabel.Text = "Düzenlemek veya silmek istediğiniz üyeyi sağdaki tablodan seçin. Üye düzenlerken TC kimlik numarasını düzenleyemezsiniz. \nYanlış TC kimlik numarasına sahip bir üyeyi kaydettiyseniz bu üyeyi silip yeni bir üye olarak tekrar ekleyin.";
            formSubTitleLabel.Visible = false;
            ToggleInputs(false);
            LoadData();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns[0].Index)
            {
                // "IsActive" kolonunun değerini kontrol edelim.
                bool isActive = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["IsActive"].Value);

                // "IsActive" değerine göre "Üyelik Durumu" kolonunu ayarlayalım.
                e.Value = isActive ? "Aktif Üye" : "Pasif Üye";
                e.FormattingApplied = true;
            }
        }

        private void dataGridView1_SelectRow(object sender, DataGridViewCellEventArgs e)
        {
            // Bu fonksiyon hem hücre içeriğine tıklandığında hemde satır seçildiğinde içeriği soldaki form kısmına atıyor.
            var rowIndex = e.RowIndex;
            if (rowIndex >= 0 && !_addMemberState)
            {
                var member = dataGridView1.Rows[rowIndex].DataBoundItem as MemberEntity;
                nameInput.Text = member.Name;
                surnameInput.Text = member.Surname;
                idInput.Text = member.Id;
                mailInput.Text = member.Email;
                cityInput.SelectedItem = member.City;
                bloodTypeInput.SelectedItem = member.BloodType;
                isActive.Checked = member.IsActive;
            }
        }

        private async void AddButtonClick(object sender, EventArgs e)
        {
            MemberEntity member = new()
            {
                Id = idInput.Text,
                City = (City)Enum.Parse(typeof(City), cityInput.Text),
                BloodType = (BloodType)Enum.Parse(typeof(BloodType), bloodTypeInput.Text),
                Email = mailInput.Text,
                Name = nameInput.Text,
                Surname = surnameInput.Text,
                IsActive = isActive.Checked
            };


            try
            {
                var existingMember = _memberReadRepository.Any(member.Id);
                if (existingMember)
                {
                    throw new InvalidOperationException("Eklemeye çalıştığınız üyenin kimlik numarası veritabanında mevcut.");
                }
                else
                {
                    // validasyon işlemleri
                    // tc kimlik validasyonunu yazdığımız helper metodumuz ile yapıyoruz.

                    bool TcCheck = IdentityNumberVerification.Check(member.Id);
                    MailAddress mailAddress = new(member.Email);
                    if (!TcCheck)
                    {
                        throw new ArgumentException("Girmiş olduğunuz TC kimlik numarası geçersizdir, lütfen tekrar deneyin");
                    }
                    else if (mailAddress.Address != member.Email)
                    {
                        throw new ArgumentException("Girmiş olduğunuz e posta adresi geçersizdir, lütfen tekrar deneyin");
                    }
                    else
                    {
                        await _memberWriteRepository.AddAsync(member);
                        await _memberWriteRepository.SaveAsync();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Girdiğiniz bilgileri kontrol edip tekrar deneyin.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadData();
                ClearInputs();
            }

        }

        private void ClearInputs()
        {
            nameInput.Clear();
            surnameInput.Clear();
            idInput.Clear();
            mailInput.Clear();
            cityInput.SelectedIndex = 0;
            bloodTypeInput.SelectedIndex = 0;
            isActive.Checked = true;
        }

        private void ToggleForm()
        {
            if (_addMemberState)
            {
                formTitleLabel.Text = "Üye Ekleme";
                addButton.Visible = true;
                updateButton.Visible = false;
                deleteButton.Visible = false;
                formSubTitleLabel.Visible = false;
                dataGridView1.ClearSelection();
                ToggleInputs(true);
                ClearInputs();
            }
            else
            {
                formTitleLabel.Text = "Üye Düzenle / Sil";
                formSubTitleLabel.Visible = true;
                addButton.Visible = false;
                updateButton.Visible = true;
                deleteButton.Visible = true;
                ToggleInputs(true);
                idInput.Enabled = false;
            }

        }
        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            _addMemberState = true;
            ToggleForm();
        }

        private void UpdateMemberButton_Click(object sender, EventArgs e)
        {
            _addMemberState = false;
            ToggleForm();
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                MemberEntity currentMember = await _memberReadRepository.GetByIdAsync(idInput.Text);
                currentMember.Name = nameInput.Text;
                currentMember.Surname = surnameInput.Text;
                currentMember.Email = mailInput.Text;
                currentMember.City = (City)Enum.Parse(typeof(City), cityInput.Text);
                currentMember.BloodType = (BloodType)Enum.Parse(typeof(BloodType), bloodTypeInput.Text);
                currentMember.IsActive = isActive.Checked;

                _memberWriteRepository.Update(currentMember);
                await _memberWriteRepository.SaveAsync();
            }
            catch (Exception)
            {
                throw new Exception("Güncelleme sırasında bir hata oluştu lütfen daha sonra tekrar deneyin.");
            }
            finally
            {
                LoadData();
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Silmek istediğinize emin misiniz?", "Üye Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    MemberEntity currentMember = await _memberReadRepository.GetByIdAsync(idInput.Text);
                    _memberWriteRepository.Remove(currentMember);
                    await _memberWriteRepository.SaveAsync();
                }
                catch (Exception)
                {
                    throw new Exception("Silme sırasında bir hata oluştu lütfen daha sonra tekrar deneyin.");
                }
                finally
                {
                    LoadData();
                }
            }
        }
    }
}


// ToDo: Üye Güncelleme / Silme İşlemleri / Hata Yönetim [x]
//  ToDo: Silme işleminde seçili satırı silmek istediğinize emin misiniz diye sorup evete basınca sileriz. Ödemelerle cascade kısmı falan var ona sonra bakacağız.[x]
// ToDo: Filtreleme sistemi