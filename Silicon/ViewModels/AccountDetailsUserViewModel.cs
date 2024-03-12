using Silicon.Models;

namespace Silicon.ViewModels;

public class AccountDetailsUserViewModel
{
	public string Title { get; set; } = "AccountDetails";

	public AccountDetailsUserModel UserForm { get; set; } = new AccountDetailsUserModel();

	public AccountDetailsAdressModel AdressForm { get; set; } = new AccountDetailsAdressModel();
}
