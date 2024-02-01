using System.ComponentModel.DataAnnotations;

namespace Ticket1.Model
{
    public class RegisterModel
    {
        [Required(ErrorMessage ="Mobile Number is required")]
        public string MobileNo { get; set; }

        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
}
