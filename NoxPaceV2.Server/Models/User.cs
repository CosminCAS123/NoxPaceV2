using System.ComponentModel.DataAnnotations;

namespace NoxPaceV2.Server.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string PasswordHash { get; set; } = string.Empty;
        [Required]
        [MaxLength(30)]
        public string? Username { get; set; }
    }
}
