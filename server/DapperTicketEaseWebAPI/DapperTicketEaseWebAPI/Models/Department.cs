using System.ComponentModel.DataAnnotations;

namespace DapperTicketEaseWebAPI.Models
{
    public class Department
    {
        [Key]
        public string dept_id { get; set; }

        public string dept_name { get; set; }

        public string dept_head { get; set; }
    }
}
