using Dapper;
using DapperTicketEaseWebAPI.Models.Data;
using DapperTicketEaseWebAPI.Models.Repo;
using System;

namespace DapperTicketEaseWebAPI.Models.RequestRepository
{
    public class RequestRepo:IRequestRepo
    {
        private readonly DapperDBContext context;

        public RequestRepo(DapperDBContext context)
        {
            this.context = context;
        }
        public async Task<string> CreateRequest(Request request)
        {
            string response = string.Empty;
            string query = "Insert into requests(firstname,lastname,email,password,profile_link,dept_id,bu_id,manager_id,blood_type,is_admin,joined_on) values  (@firstname,@lastname,@email,@password,@profile_link,@dept_id,@bu_id,@manager_id,@blood_type,@is_admin,@joined_on);";
            var parameters = new DynamicParameters();

            parameters.Add("firstname", request.request_type, System.Data.DbType.String);
            parameters.Add("dept_id", request.dept_id, System.Data.DbType.Int64);
            parameters.Add("joined_on", request.created_on, System.Data.DbType.Date);
            parameters.Add("joined_on", request.updated_on, System.Data.DbType.Date);

            using (var connection = context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
                response = "pass";
            }

            return response;
        }
        public async Task<List<Request>> GetAllRequests()
        {
            string query = "Select * from Request";
            using (var connection = context.CreateConnection())
            {
                var reqlist = await connection.QueryAsync<Request>(query);
                return reqlist.ToList();
            }
        }
        public async Task<string> RemoveRequest(string request_type)
        {
            string response = string.Empty;
            string query = "Delete from request where request_type=@request_type";
            var parameters = new DynamicParameters();

            parameters.Add("request_type", request_type, System.Data.DbType.String);

            using (var connection = context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
                response = "pass";
            }

            return response;
        }

        public async Task<string> UpdateRequest(Request request)
        {
            string response = string.Empty;
            string query = "Update employees set request_type=@request_type,dept_id=@dept_id,created_on=@created_on,updated_on=@updated_on where request_type=@request_type;";
            var parameters = new DynamicParameters();

            parameters.Add("request_type", request.request_type, System.Data.DbType.String);
            parameters.Add("dept_id", request.dept_id, System.Data.DbType.Int64);
            parameters.Add("created_on", request.created_on, System.Data.DbType.Date);
            parameters.Add("updated_on", request.updated_on, System.Data.DbType.Date);

            using (var connection = context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
                response = "pass";
            }

            return response;
        }
    }
}
