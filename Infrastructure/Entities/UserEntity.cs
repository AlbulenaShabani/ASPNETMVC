

using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;

namespace Infrastructure.Entities;

public class UserEntity
{
	[Key]
	public string Id { get; set; } = null!;
	public string FirstName { get; set; } = null!;
	string LastName { get; set; } = null!;
	public string Email { get; set; } = null!;
	public string Password { get; set; } = null!;
	public string SecurityKey { get; set; } = null!;
	public string? PhoneNumber { get; set; } 
	public string? Biography { get; set; } 
	public DateTime? Created {  get; set; }
	public DateTime? modified { get; set;}

	public int AdressId { get; set; }
	public AddressEntity? Address { get; set; }

}
