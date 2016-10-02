using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MVCOwin.ViewModels
{
    public class LogInModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        // hide this one
        [HiddenInput(DisplayValue = false)]
        public string ReturnUrl { get; set; }
    }
}