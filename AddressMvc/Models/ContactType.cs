using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AddressMvc.Models
{
    public class ContactType
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Type")]
        [StringLength(20, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string Name { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}