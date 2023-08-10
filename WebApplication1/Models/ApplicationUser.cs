using System.ComponentModel.DataAnnotations;

namespace Lab12.Models
{
    public class ApplicationUser
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}