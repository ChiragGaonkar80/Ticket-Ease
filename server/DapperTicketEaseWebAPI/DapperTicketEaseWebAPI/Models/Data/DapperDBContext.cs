using Microsoft.Data.SqlClient;
using System.Data;

namespace DapperTicketEaseWebAPI.Models.Data
{
    public class DapperDBContext
    {
        private readonly IConfiguration _configuration;
        private readonly string connectionstring;


        public DapperDBContext(IConfiguration configuration)
        {
            this._configuration = configuration;
            this.connectionstring = _configuration.GetConnectionString("DefaultConnection");

        }

        public IDbConnection CreateConnection() => new SqlConnection(connectionstring);



    }
}
