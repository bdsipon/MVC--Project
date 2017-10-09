using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AddressMvc.Models
{
    public class Status
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Status Name")]
        [StringLength(20, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string Name { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }

    }
}