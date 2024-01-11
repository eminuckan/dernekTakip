using Dernek.Application.Repositories.Member;
using Dernek.Application.Repositories.MembershipFee;
using Dernek.Application.Repositories.Payment;
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
        private readonly IMembershipFeeReadRepository _membershipFeeReadRepository;
        private readonly IMembershipFeeWriteRepository _membershipFeeWriteRepository;
        private readonly IPaymentReadRepository _paymentReadRepository;
        private readonly IPaymentWriteRepository _paymentWriteRepository;
        public Main(IMemberWriteRepository memberWriteRepository,
            IMemberReadRepository memberReadRepository, IMembershipFeeWriteRepository membershipFeeWriteRepository, IMembershipFeeReadRepository membershipFeeReadRepository, IPaymentReadRepository paymentReadRepository, IPaymentWriteRepository paymentWriteRepository)
        {
            _memberWriteRepository = memberWriteRepository;
            _memberReadRepository = memberReadRepository;
            _membershipFeeReadRepository = membershipFeeReadRepository;
            _membershipFeeWriteRepository = membershipFeeWriteRepository;
            _paymentReadRepository = paymentReadRepository;
            _paymentWriteRepository = paymentWriteRepository;
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

        private void membershipFee_Click_1(object sender, EventArgs e)
        {
            container.Controls.Clear();
            MembershipFee membershipFee = new(_membershipFeeWriteRepository, _membershipFeeReadRepository);
            container.Controls.Add(membershipFee);
        }

        private void payments_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            Payments payments = new(_memberReadRepository, _membershipFeeReadRepository, _paymentReadRepository, _paymentWriteRepository);
            container.Controls.Add(payments);
        }
    }
}
