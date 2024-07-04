using System.ComponentModel.DataAnnotations;

namespace Lab.Model
{
    public class SignUpDTO
    {
        [Required]
        public string Username { get; set; }


        [Required]
        public string Gender { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

    }
}
