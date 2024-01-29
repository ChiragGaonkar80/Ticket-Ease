using DapperTicketEaseWebAPI.Models;
using DapperTicketEaseWebAPI.Models.Repo;
using DapperTicketEaseWebAPI.Models.RequestRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperRequestEaseWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private readonly IRequestRepo _repo;

        public RequestController(IRequestRepo _repo)
        {
            this._repo = _repo;
        }


        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var _list = await this._repo.GetAllRequests();
            if (_list != null)
            {
                return Ok(_list);
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost("CreateRequest")]
        public async Task<IActionResult> CreateRequest([FromBody] Request Request)
        {
            var _result = await this._repo.CreateRequest(Request);

            return Ok(_result);

        }

        [HttpPost("UpdateRequest")]
        public async Task<IActionResult> UpdateRequest([FromBody] Request Request)
        {
            var _result = await this._repo.UpdateRequest(Request);

            return Ok(_result);

        }

        [HttpPost("RemoveRequest")]
        public async Task<IActionResult> RemoveRequest(string request_type)
        {
            var _result = await this._repo.RemoveRequest(request_type);

            return Ok(_result);

        }
    }
}

