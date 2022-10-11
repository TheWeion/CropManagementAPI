using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CropManagementSystem.Data
{
    public class Track
    {
        [Required]
        [Key]
        public int track_id { get; set; }

        [ForeignKey("User")]
        [Required]
        public int user_id { get; set; }

        [Required]
        public int crop_id { get; set; }

        public DateTime sown { get; set; }

        public DateTime watered { get; set; }
        public DateTime[] fed { get; set; }
        public DateTime[] harvested { get; set; }
    }
}
