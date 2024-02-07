using System.ComponentModel.DataAnnotations;

namespace DapperTicketEaseWebAPI.Models
{
    public class TicketComment
    {
        [Key]
        public string comment_id { get; set; }
        public string description { get; set; }
        public string ticket_id { get; set; }
        public string status_title { get; set; }
        public DateTime? created_on { get; set; }
        public DateTime? updated_on { get; set; }
    }
}
