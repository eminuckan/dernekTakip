using Dernek.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.Core.Entities
{
    public class MembershipFeeEntity : BaseEntity
    {
        Month Month { get; set; }
        public decimal Fee { get; set; }

        public ICollection<PaymentEntity> Payments { get; set; }
    }
}
