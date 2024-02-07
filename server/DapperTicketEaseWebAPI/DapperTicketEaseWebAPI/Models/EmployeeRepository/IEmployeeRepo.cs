namespace DapperTicketEaseWebAPI.Models.Repo
{
    public interface IEmployeeRepo
    {
        public Task<List<Employee>> GetAllEmployees();

        public Task<Employee> Login(string email, string password, bool isAdmin);

        public Task<Employee> GetEmployeeById(string emp_id);

        public Task<List<TicketStatusCount>> GetTicketStatusCountsForAdmin(string emp_id);

        public Task<List<TicketPriorityCount>> GetTicketPriorityCountsForAdmin(string emp_id);
        
        public Task<string> CreateEmployee(Employee employee);

        public Task<string> UpdateEmployee(Employee employee);

        public Task<string> RemoveEmployee(string emp_id);

        public Task<string> SeeEmployee(string email, string password, bool isAdmin);
        public Task<List<Employee>> GetAllManagers();
    }
}
