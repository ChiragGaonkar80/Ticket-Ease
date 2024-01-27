using DapperTicketEaseWebAPI.Models;
using DapperTicketEaseWebAPI.Models.BURepo;
using DapperTicketEaseWebAPI.Models.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperTicketEaseWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BUController : ControllerBase
    {
        private readonly IBURepo repo;

        public BUController(IBURepo repo)
        {
            this.repo = repo;
        }


        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var _list = await this.repo.GetAllBUs();
            if (_list != null)
            {
                return Ok(_list);
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost("CreateBU")]
        public async Task<IActionResult> CreateBU([FromBody] BU bu)
        {
            var _result = await this.repo.CreateBU(bu);

            return Ok(_result);

        }

        [HttpPost("UpdateBU")]
        public async Task<IActionResult> UpdateBU([FromBody] BU bu)
        {
            var _result = await this.repo.UpdateBU(bu);

            return Ok(_result);

        }

        [HttpPost("RemoveBU")]
        public async Task<IActionResult> RemoveBU(int id)
        {
            var _result = await this.repo.RemoveBU(id);

            return Ok(_result);

        }
    }
}
