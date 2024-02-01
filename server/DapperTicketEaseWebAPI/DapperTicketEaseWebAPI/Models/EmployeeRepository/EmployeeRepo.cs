using Dapper;
using DapperTicketEaseWebAPI.Models.Data;
using System.Text.Json;

namespace DapperTicketEaseWebAPI.Models.Repo
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly DapperDBContext context;

        public EmployeeRepo(DapperDBContext context)
        {
            this.context = context;
        }

        public async Task<string> CreateEmployee(Employee employee)
        {
            string response = string.Empty;
            string query = "Insert into employees(firstname,lastname,email,password,profile_link,dept_id,bu_id,manager_id,blood_type,is_admin,joined_on) values  (@firstname,@lastname,@email,@password,@profile_link,@dept_id,@bu_id,@manager_id,@blood_type,@is_admin,@joined_on);";
            var parameters = new DynamicParameters();

            parameters.Add("firstname", employee.firstname, System.Data.DbType.String);
            parameters.Add("lastname", employee.lastname, System.Data.DbType.String);
            parameters.Add("email", employee.email, System.Data.DbType.String);
            parameters.Add("password", employee.password, System.Data.DbType.String);
            parameters.Add("profile_link", employee.profile_link, System.Data.DbType.String);
            parameters.Add("dept_id", employee.dept_id, System.Data.DbType.Int64);
            parameters.Add("bu_id", employee.bu_id, System.Data.DbType.Int64);
            parameters.Add("manager_id", employee.manager_id, System.Data.DbType.Int64);
            parameters.Add("blood_type", employee.blood_type, System.Data.DbType.String);
            parameters.Add("is_admin", employee.is_admin, System.Data.DbType.Boolean);
            parameters.Add("joined_on", employee.joined_on, System.Data.DbType.Date);

            using (var connection = context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
                response = "pass";
            }

            return response;
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            string query = "Select * from employees";
            using (var connection = context.CreateConnection())
            {
                var emplist = await connection.QueryAsync<Employee>(query);
                return emplist.ToList();

            }
        }
        public async Task<List<TicketStatusCount>> GetTicketStatusCountsForAdmin(int emp_id)
        {
            using (var connection = context.CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@emp_id", emp_id, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
        
                var result = await connection.QueryAsync<TicketStatusCount>("GetTicketStatusCountsForAdmin", parameters, commandType: System.Data.CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<TicketPriorityCount>> GetTicketPriorityCountsForAdmin(int emp_id)
        {
            using (var connection = context.CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@emp_id", emp_id, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);

                var result = await connection.QueryAsync<TicketPriorityCount>("GetTicketPriorityCountsForAdmin", parameters, commandType: System.Data.CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<Employee> Login(string email, string password, bool isAdmin)
        {

            string query = "Select * from employees where email=@email and password=@password and is_admin=@isAdmin";
            var parameters = new DynamicParameters();

            parameters.Add("email", email, System.Data.DbType.String);
            parameters.Add("password", password, System.Data.DbType.String);
            parameters.Add("isAdmin", isAdmin, System.Data.DbType.Boolean);

            using (var connection = context.CreateConnection())
            {
                var emp = await connection.QueryFirstOrDefaultAsync<Employee>(query, parameters);
                return emp;
            }

        }

        public async Task<string> SeeEmployee(string email, string password, bool isAdmin)
        {

            string query = "select * from employees e inner join bu b on e.bu_id = b.bu_id";
            var parameters = new DynamicParameters();

            //parameters.Add("email", email, System.Data.DbType.String);
            //parameters.Add("password", password, System.Data.DbType.String);
            //parameters.Add("isAdmin", isAdmin, System.Data.DbType.Boolean);

            using (var connection = context.CreateConnection())
            {
                var emplist = await connection.QueryFirstOrDefaultAsync<dynamic>(query, parameters);

                string jsonString = JsonSerializer.Serialize(emplist);
                return jsonString;
            }

        }





        public async Task<string> RemoveEmployee(string email)
        {
            string response = string.Empty;
            string query = "Delete from employees where email=@email";
            var parameters = new DynamicParameters();

            parameters.Add("email", email, System.Data.DbType.String);

            using (var connection = context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
                response = "pass";
            }

            return response;
        }

        public async Task<string> UpdateEmployee(Employee employee)
        {
            string response = string.Empty;
            string query = "Update employees set firstname=@firstname,lastname=@lastname,email=@email,password=@password,profile_link=@profile_link,dept_id=@dept_id,bu_id=@bu_id,manager_id=@manager_id,blood_type=@blood_type,is_admin=@is_admin,joined_on=@joined_on where email=@email;";
            var parameters = new DynamicParameters();

            parameters.Add("firstname", employee.firstname, System.Data.DbType.String);
            parameters.Add("lastname", employee.lastname, System.Data.DbType.String);
            parameters.Add("email", employee.email, System.Data.DbType.String);
            parameters.Add("password", employee.password, System.Data.DbType.String);
            parameters.Add("profile_link", employee.profile_link, System.Data.DbType.String);
            parameters.Add("dept_id", employee.dept_id, System.Data.DbType.Int64);
            parameters.Add("bu_id", employee.bu_id, System.Data.DbType.Int64);
            parameters.Add("manager_id", employee.manager_id, System.Data.DbType.Int64);
            parameters.Add("blood_type", employee.blood_type, System.Data.DbType.String);
            parameters.Add("is_admin", employee.is_admin, System.Data.DbType.Boolean);
            parameters.Add("joined_on", employee.joined_on, System.Data.DbType.Date);

            using (var connection = context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
                response = "pass";
            }

            return response;
        }
    }
}
