using Dernek.Core.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dernek.Core.Entities
{
    public class MemberEntity : BaseEntity
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public City City { get; set; }
        [Required]
        public BloodType BloodType { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool IsActive { get; set; }
    }
}
