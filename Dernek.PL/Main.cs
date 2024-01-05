using Dernek.Application.Repositories.Member;
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
    public partial class Main : Form
    {
        private readonly IMemberWriteRepository _memberWriteRepository;
        private readonly IMemberReadRepository _memberReadRepository;
        public Main(IMemberWriteRepository memberWriteRepository,
            IMemberReadRepository memberReadRepository)
        {
            _memberWriteRepository = memberWriteRepository;
            _memberReadRepository = memberReadRepository;
            InitializeComponent();
        }

        private void LoadHome()
        {
            container.Controls.Clear();
            Home home = new(_memberReadRepository);
            container.Controls.Add(home);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadHome();
        }

        private void home_Click(object sender, EventArgs e)
        {
            LoadHome();


        }

        private void members_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            Members members = new(_memberWriteRepository, _memberReadRepository);
            container.Controls.Add(members);
        }
    }
}
