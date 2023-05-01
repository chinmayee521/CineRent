using System;
using System.ComponentModel.DataAnnotations;

namespace CineRent.Models
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; } //navigation property

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; } //foreign key

        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }
    }
}