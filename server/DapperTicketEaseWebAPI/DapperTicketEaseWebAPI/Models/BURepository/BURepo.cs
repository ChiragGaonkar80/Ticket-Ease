
using Dapper;
using DapperTicketEaseWebAPI.Models.Data;

namespace DapperTicketEaseWebAPI.Models.BURepo
{
    public class BURepo : IBURepo
    {
        private readonly DapperDBContext context;

        public BURepo(DapperDBContext context)
        {
            this.context = context;
        }

        private string GenerateBuId()
        {
            Guid g = Guid.NewGuid();
            string id = "bu_" + g.ToString();
            return id;
        }

        public async Task<string> CreateBU(BU bu)
        {
            string response = string.Empty;
            string query = "Insert into bu(bu_id,bu_name,is_du) values (@bu_id,@bu_name,@is_du);";
            var parameters = new DynamicParameters();

            parameters.Add("bu_id", GenerateBuId(), System.Data.DbType.String);
            parameters.Add("bu_name", bu.bu_name, System.Data.DbType.String);
            parameters.Add("is_du", bu.is_du, System.Data.DbType.Boolean);


            using (var connection = context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
                response = "pass";
            }

            return response;
        }

        public async Task<List<BU>> GetAllBUs()
        {
            string query = "Select * from bu";
            using (var connection = context.CreateConnection())
            {
                var bulist = await connection.QueryAsync<BU>(query);
                return bulist.ToList();

            }
        }

        public async Task<string> RemoveBU(string bu_id)
        {
            string response = string.Empty;
            string query = "Delete from bu where bu_id=@bu_id";
            var parameters = new DynamicParameters();

            parameters.Add("bu_id", bu_id, System.Data.DbType.String);

            using (var connection = context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
                response = "pass";
            }

            return response;
        }

        public async Task<string> UpdateBU(BU bu)
        {
            string response = string.Empty;
            string query = "Update bu set bu_name=@bu_name, is_du=@is_du where bu_id=@bu_id;";
            var parameters = new DynamicParameters();

            parameters.Add("bu_id", bu.bu_id, System.Data.DbType.String);
            parameters.Add("bu_name", bu.bu_name, System.Data.DbType.String);
            parameters.Add("is_du", bu.is_du, System.Data.DbType.Boolean);


            using (var connection = context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
                response = "pass";
            }

            return response;
        }

    }
}
