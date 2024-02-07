using System.ComponentModel.DataAnnotations;

namespace DapperTicketEaseWebAPI.Models
{
    public class BU
    {
        [Key]
        public string bu_id { get; set; }

        public string bu_name { get; set; }

        public bool is_du { get; set; }
    }
}
