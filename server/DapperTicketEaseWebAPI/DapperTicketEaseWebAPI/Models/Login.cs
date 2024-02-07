namespace DapperTicketEaseWebAPI.Models
{
    public class Login
    {
        public string email { get; set; }
        public string password { get; set; }
        public bool isAdminLogIn { get; set; }
    }
}
