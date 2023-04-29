using System.ComponentModel.DataAnnotations;

namespace CineRent.Models
{
    public class MembershipType
    {
        public byte Id { get; set; } //primary key
        [Required]
        public string Name { get; set; }
        public short SignupFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

    }
}