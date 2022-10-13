using System.ComponentModel.DataAnnotations;

namespace CropManagementSystem.Data
{
    public class User
    {
        [Key]
        public int user_id { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }

        public string email { get; set; }

        public string? displayname { get; set; }
        
        public string? bio { get; set; }

        public string[]? favourite_crops { get; set; }
    }
}