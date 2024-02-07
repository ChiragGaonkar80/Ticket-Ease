using System.ComponentModel.DataAnnotations;

namespace DapperTicketEaseWebAPI.Models
{
    public class RequestType
    {
        [Key]
        public string request_type_id { get; set; }
        public required string request_type { get; set; }
        public string dept_id { get; set; }
        public string description { get; set; }
        public bool is_incident { get; set; }
        public required string structure { get; set; }
    }
}
