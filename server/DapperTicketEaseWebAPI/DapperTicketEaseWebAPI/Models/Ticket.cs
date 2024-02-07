using System.ComponentModel.DataAnnotations;

namespace DapperTicketEaseWebAPI.Models
{
    public class Ticket
    {
        [Key]
        public string ticket_id { get; set; }
        public string title { get; set; }
        public string? formdata { get; set; }
        public string emp_id { get; set; }
        public string dept_id { get; set; }
        public string? admin_id { get; set; }
        public string? manager_id { get; set; }
        public string request_type_id { get; set; }
        public string status_id { get; set; }
        public DateTime? created_on { get; set; }
        public DateTime? updated_on { get; set; }
        public bool? need_approval { get; set; }
        public string status_title { get; set; }

        public string priority {  get; set; }
    }
}
