using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.PL.ViewModels
{
    public class PaymentInfoViewModel
    {
        public string PaymentId { get; set; }
        public string MemberId { get; set; }
        public string MemberFullName { get; set; }
        public string Month { get; set; }
        public string MembershipFee { get; set; }
        public string PaymentDate { get; set; }
    }
}
