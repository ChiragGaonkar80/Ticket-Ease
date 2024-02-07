namespace DapperTicketEaseWebAPI.Models.DepartmentRepository
{
    public interface IDepartmentRepo
    {
        public Task<List<Department>> GetAllDepartments();

        public Task<string> CreateDepartment(Department department);

        public Task<string> UpdateDepartment(Department department);

        public Task<string> RemoveDepartment(string dept_id);
    }
}
