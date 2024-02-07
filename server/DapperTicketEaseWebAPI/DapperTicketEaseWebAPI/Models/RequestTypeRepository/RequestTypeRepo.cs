using Dapper;
using DapperTicketEaseWebAPI.Models.Data;
using DapperTicketEaseWebAPI.Models.Repo;
using System;

namespace DapperTicketEaseWebAPI.Models.RequestRepository
{
    public class RequestTypeRepo:IRequestTypeRepo
    {
        private readonly DapperDBContext context;

        public RequestTypeRepo(DapperDBContext context)
        {
            this.context = context;
        }

        public string GenerateRequestTypeId()
        {
            Guid g = Guid.NewGuid();
            string id = "rqsttyp_" + g.ToString();
            return id;
        }

        public async Task<string> CreateRequestType(RequestType requestType)
        {
            string response = string.Empty;
            string query = "Insert into requesttypes (request_type_id, request_type, dept_id, description, is_incident, structure) values (@request_type_id, @request_type, @dept_id, @description, @is_incident, @structure);";
            var parameters = new DynamicParameters();

            parameters.Add("request_type_id", GenerateRequestTypeId(), System.Data.DbType.String);
            parameters.Add("request_type", requestType.request_type, System.Data.DbType.String);
            parameters.Add("dept_id", requestType.dept_id, System.Data.DbType.String);
            parameters.Add("description", requestType.description, System.Data.DbType.String);
            parameters.Add("is_incident", requestType.is_incident, System.Data.DbType.Boolean);
            parameters.Add("structure", requestType.structure, System.Data.DbType.String);

            using (var connection = context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
                response = "pass";
            }

            return response;
        }
        public async Task<List<RequestType>> GetAllRequestTypes()
        {
            string query = "Select * from requesttypes";
            using (var connection = context.CreateConnection())
            {
                var reqlist = await connection.QueryAsync<RequestType>(query);
                return reqlist.ToList();
            }
        }

        public async Task<RequestType> GetRequestTypeById(string request_type_id)
        {
            string query = "Select * from requesttypes where request_type_id=@request_type_id";

            var parameters = new DynamicParameters();
            parameters.Add("request_type_id", request_type_id, System.Data.DbType.String);

            using (var connection = context.CreateConnection())
            {
                var requestType = await connection.QueryFirstOrDefaultAsync<RequestType>(query, parameters);
                return requestType;
            }
        }

        public async Task<List<RequestType>> GetRequestTypesByDeptId(string dept_id)
        {
            string query = "Select * from requesttypes where dept_id=@dept_id";
            var parameters = new DynamicParameters();

            parameters.Add("dept_id", dept_id, System.Data.DbType.String);

            using (var connection = context.CreateConnection())
            {
                var reqlist = await connection.QueryAsync<RequestType>(query, parameters);
                return reqlist.ToList();
            }

        }

        public async Task<string> RemoveRequestType(string request_type_id)
        {
            string response = string.Empty;
            string query = "Delete from requesttypes where request_type_id=@request_type_id";
            var parameters = new DynamicParameters();

            parameters.Add("request_type_id", request_type_id, System.Data.DbType.String);

            using (var connection = context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
                response = "pass";
            }

            return response;
        }

        public async Task<string> UpdateRequestType(RequestType requestType)
        {
            string response = string.Empty;
            string query = "Update requesttypes set request_type=@request_type,dept_id=@dept_id, description=@description, is_incident=@is_incident, structure=@structure  where request_type_id=@request_type_id;";
            var parameters = new DynamicParameters();

            parameters.Add("request_type_id", requestType.request_type_id, System.Data.DbType.String);
            parameters.Add("request_type", requestType.request_type, System.Data.DbType.String);
            parameters.Add("dept_id", requestType.dept_id, System.Data.DbType.String);
            parameters.Add("description", requestType.description, System.Data.DbType.String);
            parameters.Add("is_incident", requestType.is_incident, System.Data.DbType.Boolean);
            parameters.Add("structure", requestType.structure, System.Data.DbType.String);

            using (var connection = context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
                response = "pass";
            }

            return response;
        }
    }
}
