namespace DapperTicketEaseWebAPI.Models.Repo
{
    public interface IEmployeeRepo
    {
        public Task<List<Employee>> GetAllEmployees();

        public Task<Employee> Login(string email, string password, bool isAdmin);

        public Task<List<TicketStatusCount>> GetTicketStatusCountsForAdmin(int emp_id);

        public Task<List<TicketPriorityCount>> GetTicketPriorityCountsForAdmin(int emp_id);
        
        public Task<string> CreateEmployee(Employee employee);

        public Task<string> UpdateEmployee(Employee employee);

        public Task<string> RemoveEmployee(string email);

        public Task<string> SeeEmployee(string email, string password, bool isAdmin);
    }
}
