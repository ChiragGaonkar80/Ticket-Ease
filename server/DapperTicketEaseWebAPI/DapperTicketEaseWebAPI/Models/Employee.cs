using System.ComponentModel.DataAnnotations;

namespace DapperTicketEaseWebAPI.Models
{
    public class Employee
    {
        [Key]
        public int emp_id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string profile_link { get; set; }
        public int dept_id { get; set; }
        public int bu_id { get; set; }
        public int? manager_id { get; set; }
        public string blood_type { get; set; }
        public bool is_admin { get; set; }
        public DateTime? joined_on { get; set; }
    }
}
