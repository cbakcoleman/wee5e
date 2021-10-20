using System.ComponentModel.DataAnnotations;

namespace wee5e.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage = "You must enter an email.")]
        [Display(Name = "Email: ")]
        public string LoginEmail {get;set;}

        [Required(ErrorMessage = "You must enter a pasword")]
        [DataType(DataType.Password)]
        [Display(Name = "Password: ")]
        public string LoginPassword {get;set;}
    }
}
