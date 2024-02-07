using DapperTicketEaseWebAPI.Models;
using DapperTicketEaseWebAPI.Models.Repo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
//using System.Web.Http;

namespace DapperTicketEaseWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private IConfiguration _configuration;

        private readonly IEmployeeRepo repo;

        public EmployeeController(IEmployeeRepo repo, IConfiguration configuration)
        {
            this.repo = repo;
            _configuration = configuration;
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] Login loginDetails)
        {
            /*
             dummy data for log in
            {
                "email": "siya@gmail.com",
              "password": "siya123",
              "isAdmin": false
            }
            */
            var _emp = await this.repo.Login(loginDetails.email, loginDetails.password, loginDetails.isAdminLogIn);
            IActionResult response = Unauthorized();
            if (_emp != null)
            {
                var token = GenerateToken(_emp);
                response =  Ok(new { token = token, payload = _emp });
                return response;
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("GetEmployeeById")]
        public async Task<IActionResult> GetEmployeeById(string emp_id)
        {
            var _emp = await this.repo.GetEmployeeById(emp_id);
            if (_emp != null)
            {
                var response = Ok(_emp);
                return response;
            }
            else
            {
                return NotFound();
            }

        }

        [Authorize]
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

        [HttpGet("GetAllManagers")]
        public async Task<IActionResult> GetAllManagers()
        {
            var _list = await this.repo.GetAllManagers();
            if (_list != null)
            {
                return Ok(_list);
            }
            else
            {
                return NotFound();
            }

        }
        
        [HttpGet("GetManagerByEmpId")]
        public async Task<IActionResult> GetManagerByEmpId(string emp_id)
        {
            var _emp = await this.repo.GetManagerByEmpId(emp_id);
            if (_emp != null)
            {
                var response = Ok(_emp);
                return response;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("GetTicketStatusCountsForAdmin")]
        public async Task<IActionResult> GetTicketStatusCountsForAdmin(string emp_id)
        {
            var statusCounts = await this.repo.GetTicketStatusCountsForAdmin(emp_id);
            if (statusCounts != null && statusCounts.Any())
            {
                return Ok(statusCounts);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet("GetTicketPriorityCountsForAdmin")]
        public async Task<IActionResult> GetTicketPriorityCountsForAdmin(string emp_id)
        {
            var statusCounts = await this.repo.GetTicketPriorityCountsForAdmin(emp_id);
            if (statusCounts != null && statusCounts.Any())
            {
                return Ok(statusCounts);
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

        [HttpPut("UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee([FromBody] Employee employee)
        {
            var _result = await this.repo.UpdateEmployee(employee);

            return Ok(_result);

        }

        [HttpDelete("RemoveEmployee")]
        public async Task<IActionResult> RemoveEmployee(string emp_id)
        {
            var _result = await this.repo.RemoveEmployee(emp_id);

            return Ok(_result);

        }

        private string GenerateToken(Employee employee)
        {
            var securitykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWTSettings:Key"]));
            var credentials = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["JWTSettings:Issuer"],
                audience: _configuration["JWTSettings:Audience"],
                expires: DateTime.Now.AddMinutes(3),
                signingCredentials: credentials
                
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


        

    }
}
