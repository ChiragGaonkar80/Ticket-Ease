using System.ComponentModel.DataAnnotations;

namespace DapperTicketEaseWebAPI.Models
{
    public class IncidentTickets
    {
        [Key]
        public int ticket_id { get; set; }
        public int priority { get; set; }
        public string employee_email { get; set; }
        public string employee_firstname { get; set; }
        public string employee_lastname { get; set; }
        public string manager_email { get; set; }
        public string manager_firstname { get; set; }
        public string manager_lastname { get; set; }
        public string status { get; set; }
        public string request_type { get; set; }
        public DateTime? created_on { get; set; }
    }
}
