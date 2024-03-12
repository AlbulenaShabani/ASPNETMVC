using System.ComponentModel.DataAnnotations;

namespace Silicon.Models;

public class AccountDetailsUserModel
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

	[DataType(DataType.PhoneNumber)]
	[Display(Name = "Phonenumber", Prompt = "Enter your Phonenumber")]
	
	public int? PhoneNumber { get; set; }

	[DataType(DataType.Text)]
	[Display(Name = "Bio", Prompt = "Enter your Bio")]

	public string? Bio { get; set; }

}
