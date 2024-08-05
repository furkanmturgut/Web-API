using System.ComponentModel.DataAnnotations;

namespace Web_API.Dtos.Account
{
    public class LoginDto
    {
        [Required]
        public string Usernmae { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
