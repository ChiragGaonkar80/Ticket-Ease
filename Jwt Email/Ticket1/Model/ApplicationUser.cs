using Microsoft.AspNetCore.Identity;

namespace Ticket1.Model
{
    public class ApplicationUser:IdentityUser
    {
        public string MobileNo { get; set; }

    }
}
