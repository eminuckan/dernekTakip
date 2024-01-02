using Dernek.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Dernek.Core.Entities
{
    public class MemberEntity : BaseEntity
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public City City { get; set; }
        public BloodType BloodType { get; set; }
        public bool IsActive { get; set; }
    }
}
