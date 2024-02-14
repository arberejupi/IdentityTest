using System.ComponentModel.DataAnnotations;

namespace IdentityTest.Models.Authentication.Register
{
    public class RegisterUser
    {
        [Required(ErrorMessage="Username is required")]
        public string? Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }
        
        [Required(ErrorMessage = "PAssword is required")]
        public string? Password { get; set; }
        

    }
}
