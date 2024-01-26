using DapperTicketEaseWebAPI.Models;
using DapperTicketEaseWebAPI.Models.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperTicketEaseWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepo repo;

        public EmployeeController(IEmployeeRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var _list = await this.repo.GetAllEmployees();
            if(_list != null)
            {
                return Ok(_list);
            }
            else
            {
                return NotFound();
            }

        }

        
        [HttpGet("Login")]
        public async Task<IActionResult> Login(string email, string password, bool isAdmin)
        {
            var _list = await this.repo.Login(email, password, isAdmin);
            if (_list != null)
            {
                return Ok(_list);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("SeeEmployee")]
        public async Task<IActionResult> SeeEmployee(string email, string password, bool isAdmin)
        {
            var _list = await this.repo.SeeEmployee(email, password, isAdmin);
            if (_list != null)
            {
                return Ok(_list);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpPost("CreateEmployee")]
        public async Task<IActionResult> CreateEmployee([FromBody] Employee employee)
        {
            var _result = await this.repo.CreateEmployee(employee);

            return Ok(_result);
      
        }

        [HttpPost("UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee([FromBody] Employee employee)
        {
            var _result = await this.repo.UpdateEmployee(employee);

            return Ok(_result);

        }

        [HttpPost("RemoveEmployee")]
        public async Task<IActionResult> RemoveEmployee(string email)
        {
            var _result = await this.repo.RemoveEmployee(email);

            return Ok(_result);

        }
    }
}
