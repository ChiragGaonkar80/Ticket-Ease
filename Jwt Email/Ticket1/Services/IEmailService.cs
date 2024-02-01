using Ticket1.Models;

namespace Ticket1.Services.EmailService
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}