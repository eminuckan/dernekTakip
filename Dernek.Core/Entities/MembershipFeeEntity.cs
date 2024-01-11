using Dernek.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.Core.Entities
{
    public class MembershipFeeEntity : BaseEntity
    {
        [Required]
        public Month Month { get; set; }
        [DefaultValue(0)]
        public decimal Fee { get; set; }

        public ICollection<PaymentEntity> Payments { get; set; }
    }
}
