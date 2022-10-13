using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CropManagementAPI.Models
{
	public class TrackModel
	{
        [Column("track_id")]
		[Key]
		public int TrackId { get; set; }

		[Required]
		[Column("crop_id")]
		public int CropId { get; set; }

		[Required]
		[ForeignKey("User")]
		[Column("user_id")]
		public int UserId { get; set; }

		[Column("sown")]
		public DateTime? DatePlanted { get; set; }

		[Column("watered")]
		public DateTime? DateWatered { get; set; }

		[Column("fed")]
		public DateTime[]? DateFed { get; set; }

        [Column("harvested")]
        public DateTime[]? DateHarvested { get; set; }





	}
}
