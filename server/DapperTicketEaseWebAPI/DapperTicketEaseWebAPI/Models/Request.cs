using System.ComponentModel.DataAnnotations;

namespace DapperTicketEaseWebAPI.Models
{
    public class Request
    {
        [Key]
        public int request_id { get; set; }
        public required string request_type { get; set; }
        public int dept_id { get; set; }
        public DateTime? created_on { get; set; }
        public DateTime? updated_on { get; set; }
    }
}
