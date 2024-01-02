using Dernek.Application.Repositories.Member;
using Dernek.Core.Entities;
using Dernek.Core.Enums;
using ZedGraph;

namespace Dernek.PL
{
    public partial class Form1 : Form
    {

        private readonly IMemberWriteRepository _memberWriteRepository;
        private readonly IMemberReadRepository _memberReadRepository;
        public Form1(IMemberWriteRepository memberWriteRepository,
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
            dataGridView1.Columns[0].HeaderText = "TC Kimlik Numarasý";
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "E Posta";
            dataGridView1.Columns[4].HeaderText = "Þehir";
            dataGridView1.Columns[5].HeaderText = "Kan Grubu";
            dataGridView1.Columns[7].HeaderText = "Oluþturulma Tarihi";
            dataGridView1.Columns[6].Visible = false;
            // Aktiflik Durumunu Verimize Göre Yeni Bir Kolonda Aktif/Pasif Þeklinde Göstericez
            DataGridViewTextBoxColumn activeColumn = new();
            activeColumn.Name = "Üyelik Durumu";
            dataGridView1.Columns.Add(activeColumn);

            foreach (var row in dataGridView1.Rows.Cast<DataGridViewRow>())
            {
                row.Cells["Üyelik Durumu"].Value = (bool)row.Cells[6].Value ? "Aktif" : "Pasif";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            cityInput.DataSource = Enum.GetValues(typeof(City));
            bloodTypeInput.DataSource = Enum.GetValues(typeof(BloodType));
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
    }
}