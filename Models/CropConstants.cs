using System.Collections.Generic;

namespace CropManagementAPI.Models
{
	public class CropConstants
	{
		public static List<CropModel> Crops = new List<CropModel>()
		{
			new CropModel()
			{
				CropId = 1,
				UserId = 1,
				CropName = "Tomato",
				DatePlanted = new System.DateTime(2020, 1, 1),
				DateWatered = new System.DateTime(2020, 1, 1),
				DateHarvested = new System.DateTime(2020, 1, 1)
			},
			new CropModel()
			{
				CropId = 2,
				UserId = 2,
				CropName = "Potato",
				DatePlanted = new System.DateTime(2020, 1, 1),
				DateWatered = new System.DateTime(2020, 1, 1),
				DateHarvested = new System.DateTime(2020, 1, 1)
			}
		};
	}
}
