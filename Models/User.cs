using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wee5e.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}

        [Required(ErrorMessage = "You must enter name.")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters long.")]
        [Display(Name = "User Name: ")]
        public string Name {get;set;}

        [Required(ErrorMessage = "You must enter an email.")]
        [EmailAddress(ErrorMessage = "You must enter a valid email address.")]
        [Display(Name = "Email: ")]
        public string Email {get;set;}

        [Required(ErrorMessage = "You must enter a password.")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]
        [Display(Name = "Password: ")]
        public string Password {get;set;}

        [NotMapped]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password: ")]
        public string Confirm {get;set;}

        //public List<Member> Guilds {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}