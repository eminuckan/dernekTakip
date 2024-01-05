using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.Core.Entities
{
    public class PaymentEntity : BaseEntity
    {
        public DateTime PaymentDate { get; set; }
        public MemberEntity Member { get; set; }
        public MembershipFeeEntity MembershipFee { get; set; }
    }
}
