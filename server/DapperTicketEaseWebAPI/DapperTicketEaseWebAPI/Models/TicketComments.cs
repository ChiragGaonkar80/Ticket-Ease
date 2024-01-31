using System.ComponentModel.DataAnnotations;

namespace DapperTicketEaseWebAPI.Models
{
    public class TicketComments
    {
        [Key]
        public int comment_id { get; set; }
        public string description { get; set; }
        public int ticket_id { get; set; }
        public int emp_id { get; set; }
        public DateTime? created_on { get; set; }
        public DateTime? updated_on { get; set; }
    }
}
