using System.ComponentModel.DataAnnotations;

namespace DapperTicketEaseWebAPI.Models
{
    public class Ticket
    {
        [Key]
        public int ticket_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int emp_id { get; set; }
        public int dept_id { get; set; }
        public int admin_id { get; set; }
        public int manager_id { get; set; }
        public int status_id { get; set; }
        public DateTime? created_on { get; set; }
        public DateTime? updated_on { get; set; }
        public bool? need_approval { get; set; }
        public string status_title { get; set; }

        public int priority {  get; set; }
    }
}
