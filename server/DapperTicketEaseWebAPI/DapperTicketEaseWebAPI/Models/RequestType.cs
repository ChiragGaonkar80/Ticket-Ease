using System.ComponentModel.DataAnnotations;

namespace DapperTicketEaseWebAPI.Models
{
    public class RequestType
    {
        [Key]
        public int request_type_id { get; set; }
        public required string request_type { get; set; }
        public int dept_id { get; set; }
        public bool is_incident { get; set; }
        public required string structure { get; set; }
        public DateTime? created_on { get; set; }
        public DateTime? updated_on { get; set; }
    }
}
