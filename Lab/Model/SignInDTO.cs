using System.ComponentModel.DataAnnotations;

namespace Lab.Model
{
    public class SignInDTO 
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public bool RememeberMe { get; set; }
    }
}
