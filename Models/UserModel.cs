using System.ComponentModel.DataAnnotations;

namespace CropManagementAPI.Models
{
	public class UserModel
	{
		public int UserId { get; set; }
		[Required]
		[Key]
		
		public string Username { get; set; }
		[Required]
		[MinLength(5)]

		public string Password { get; set; }
		[Required]
		
		public string EmailAddress { get; set; }
		[Required]

		public string Role { get; set; }
		
		public string DisplayName { get; set; }
		[Required]
		[MaxLength(16)]

		public string Bio { get; set; }
		[MaxLength(512)]

		public string[] FavouriteCrops { get; set; }
	}
}
