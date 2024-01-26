
using Dapper;
using DapperTicketEaseWebAPI.Models.Data;

namespace DapperTicketEaseWebAPI.Models.DepartmentRepository
{
    public class DepartmentRepo : IDepartmentRepo
    {
        private readonly DapperDBContext context;

        public DepartmentRepo(DapperDBContext context)
        {
            this.context = context;
        }

        public async Task<string> CreateDepartment(Department department)
        {
            string response = string.Empty;
            string query = "Insert into department(dept_id,dept_name,dept_head) values (@dept_id,@dept_name,@dept_head);";
            var parameters = new DynamicParameters();

            parameters.Add("dept_id", department.dept_id, System.Data.DbType.Int64);
            parameters.Add("dept_name", department.dept_name, System.Data.DbType.String);
            parameters.Add("dept_head", department.dept_head, System.Data.DbType.String);


            using (var connection = context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
                response = "pass";
            }

            return response;
        }

        public async Task<List<Department>> GetAllDepartments()
        {
            string query = "Select * from department";
            using (var connection = context.CreateConnection())
            {
                var bulist = await connection.QueryAsync<Department>(query);
                return bulist.ToList();

            }
        }

        public async Task<string> RemoveDepartment(int id)
        {
            string response = string.Empty;
            string query = "Delete from bu where dept_id=@dept_id";
            var parameters = new DynamicParameters();

            parameters.Add("dept_id", id, System.Data.DbType.Int64);

            using (var connection = context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
                response = "pass";
            }

            return response;
        }

        public async Task<string> UpdateDepartment(Department department)
        {
            string response = string.Empty;
            string query = "Update department set dept_id=@dept_id, dept_name=@dept_name, dept_head=@dept_head;";
            var parameters = new DynamicParameters();

            parameters.Add("dept_id", department.dept_id, System.Data.DbType.Int64);
            parameters.Add("dept_name", department.dept_name, System.Data.DbType.String);
            parameters.Add("dept_head", department.dept_head, System.Data.DbType.String);


            using (var connection = context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
                response = "pass";
            }

            return response;
        }
    }
}
