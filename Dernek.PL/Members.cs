using Dernek.Application.Repositories.Member;
using Dernek.Core.Entities;
using Dernek.Core.Enums;
using Microsoft.EntityFrameworkCore;
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
    public partial class Members : UserControl
    {
        private readonly IMemberWriteRepository _memberWriteRepository;
        private readonly IMemberReadRepository _memberReadRepository;
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
            dataGridView1.DataSource = members.ToList();
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

        private void Members_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn uyelikDurumuKolonu = new DataGridViewTextBoxColumn
            {
                Name = "uyelikDurumu",
                HeaderText = "Üyelik Durumu Gösterim"
            };
            dataGridView1.Columns.Add(uyelikDurumuKolonu);

            cityInput.DataSource = Enum.GetValues(typeof(City));
            bloodTypeInput.DataSource = Enum.GetValues(typeof(BloodType));
            LoadData();

        }

        private async void button1_Click(object sender, EventArgs e)
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

            await _memberWriteRepository.AddAsync(member);
            await _memberWriteRepository.SaveAsync();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var member = dataGridView1.SelectedCells[e.ColumnIndex];
            MessageBox.Show(member.ToString());
        }
    }
}
