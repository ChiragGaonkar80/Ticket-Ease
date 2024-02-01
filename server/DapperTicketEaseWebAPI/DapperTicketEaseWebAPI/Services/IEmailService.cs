using DapperTicketEaseWebAPI.Models;

namespace DapperTicketEaseWebAPI.Services
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}