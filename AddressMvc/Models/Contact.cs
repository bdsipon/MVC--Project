using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AddressMvc.Models
{
    public class Contact
    {
        public int id { get; set; }

        public int ContactTypeId { get; set; }
        [Required]
        [Display(Name ="Name")]
        [StringLength(50,ErrorMessage ="The {0} must be at least{2} characters long.",MinimumLength =5)]
        public string Name { get; set; }

        [Required]
        [Display(Name ="Mobile Number")]
        [StringLength(15,ErrorMessage ="The {0} must be at least{2} character long.",MinimumLength =3)]
        public string Mobile { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Address { get; set; }
        [Required]
        public int StatusId { get; set; }

        public virtual ContactType ContactType { get; set; }
        public virtual Status Status { get; set; }

    }
}