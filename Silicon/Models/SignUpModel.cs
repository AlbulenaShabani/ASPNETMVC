using Silicon.Helpers;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ExceptionServices;
using System.Transactions;

namespace Silicon.Models
{
    public class SignUpModel
    {
        [DataType(DataType.Text)]
        [Display(Name = "First name", Prompt = "Enter your first name")]
        [Required(ErrorMessage = "First name must be provided")]

        public string FirstName { get; set; } = null!;


        [DataType(DataType.Text)]
        [Display(Name = "Last name", Prompt = "Enter your last name")]
        [Required(ErrorMessage = "Last name must be provided")]

        public string LastName { get; set; } = null!;

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address", Prompt = "Enter your email address")]
        [Required(ErrorMessage = "Email address must be provided")]

        public string Email { get; set; } = null!;


        [DataType(DataType.Password)]
        [Display(Name = "Password", Prompt = "Enter your password")]
        [Required(ErrorMessage = "Password must be provided")]

        public string Password { get; set; } = null!;


        [DataType(DataType.Password)]
        [Display(Name = "Confirm password", Prompt = "Confirm your Password")]
        [Required(ErrorMessage = "Password must match")]
        [Compare(nameof(Password))]

        public string ConfirmPassword { get; set; } = null!;


        [Display(Name = "I agree to the Terms & Conditions.")]
        [CheckBoxRequired(ErrorMessage = "You must accept the terms and conditions to proceed.")]
        public bool TermsAndConditions { get; set; } = false;
    }
}