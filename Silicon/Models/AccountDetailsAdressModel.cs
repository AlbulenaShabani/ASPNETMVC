using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace Silicon.Models;

public class AccountDetailsAdressModel
{
	[DataType(DataType.Text)]
	[Display(Name = "Adress1", Prompt = "Enter you first adress")]
	public string? Adress1 { get; set; }

	[DataType(DataType.Text)]
	[Display(Name = "Adress2", Prompt ="Enter your second adress")]
	public string? Adress2 { get; set; }

	[DataType(DataType.Text)]
	[Display(Name ="PostalCode", Prompt ="Enter your postalcode")]
	public string? PostalCode { get; set; }

	[DataType(DataType.Text)]
	[Display(Name ="City", Prompt ="Enter your City")]
	public string? City { get; set; }
}
