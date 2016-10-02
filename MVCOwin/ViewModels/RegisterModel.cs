using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCOwin.ViewModels
{
    public class RegisterModel
    {
       [Required]
       [DataType(DataType.EmailAddress)]
       public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Confirm { get; set; }

        public string Location { get; set; }

        //public int Age { get; set; }
    }
}