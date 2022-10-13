using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CropManagementAPI.Models
{
	public class CropModel
	{
		public int CropId { get; set; }
		[Required]
		[Key]

		public int UserId { get; set; }
		[ForeignKey("UserId")]
		
		public string CropName { get; set; }
		[Required]
		[MinLength(5)]

		public DateTime DatePlanted { get; set; }
		[Required]
		
		public DateTime DateWatered { get; set; }
		
		public DateTime DateHarvested { get; set; }



		

	}
}
