using System.Collections.Generic;

namespace CropManagementAPI.Models
{
	public class UserConstants
	{
		public static List<UserModel> Users = new List<UserModel>()
		{
			new UserModel()
			{
				UserId = 1,
				Username = "admin",
				Password = "admin",
				EmailAddress = "admin@cropmail.com",
				Role = "Administrator",
				DisplayName = "Admin",
				Bio = "I am the admin",
				FavouriteCrops = new string[] { "Tomato", "Potato", "Cabbage" }
			},
			new UserModel()
			{
				UserId = 2,
				Username = "user",
				Password = "user",
				EmailAddress = "user@cropmail.com",
				Role = "User",
				DisplayName = "User",
				Bio = "I am a user",
				FavouriteCrops = new string[] { "Tomato", "Potato", "Cabbage" }
			}
		};
	}
}
