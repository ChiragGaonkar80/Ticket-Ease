using DapperTicketEaseWebAPI.Models.BURepo;
using DapperTicketEaseWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DapperTicketEaseWebAPI.Models.DepartmentRepository;

namespace DapperTicketEaseWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepo repo;

        public DepartmentController(IDepartmentRepo repo)
        {
            this.repo = repo;
        }


        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var _list = await this.repo.GetAllDepartments();
            if (_list != null)
            {
                return Ok(_list);
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost("CreateDepartment")]
        public async Task<IActionResult> CreateDepartment([FromBody] Department department)
        {
            var _result = await this.repo.CreateDepartment(department);

            return Ok(_result);

        }

        [HttpPut("UpdateDepartment")]
        public async Task<IActionResult> UpdateDepartment([FromBody] Department department)
        {
            var _result = await this.repo.UpdateDepartment(department);

            return Ok(_result);

        }

        [HttpDelete("RemoveDepartment")]
        public async Task<IActionResult> RemoveDepartment(int id)
        {
            var _result = await this.repo.RemoveDepartment(id);

            return Ok(_result);

        }
    }
}
