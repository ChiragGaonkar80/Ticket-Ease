using DapperTicketEaseWebAPI.Models;
using DapperTicketEaseWebAPI.Models.Repo;
using DapperTicketEaseWebAPI.Models.RequestRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperRequestEaseWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestTypeController : ControllerBase
    {
        private readonly IRequestTypeRepo _repo;

        public RequestTypeController(IRequestTypeRepo _repo)
        {
            this._repo = _repo;
        }


        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var _list = await this._repo.GetAllRequestTypes();
            if (_list != null)
            {
                return Ok(_list);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("GetRequestTypeById")]
        public async Task<IActionResult> GetRequestTypeById(int request_type_id)
        {
            var _requestType = await this._repo.GetRequestTypeById(request_type_id);
            if (_requestType != null)
            {
                return Ok(_requestType);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("GetRequestTypesByDeptId")]
        public async Task<IActionResult> GetRequestTypesByDeptId(int dept_id)
        {
            var _requestList = await this._repo.GetRequestTypesByDeptId(dept_id);
            if (_requestList != null)
            {
                return Ok(_requestList);
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost("CreateRequest")]
        public async Task<IActionResult> CreateRequest([FromBody] RequestType Request)
        {
            var _result = await this._repo.CreateRequestType(Request);

            return Ok(_result);

        }

        [HttpPut("UpdateRequest")]
        public async Task<IActionResult> UpdateRequest([FromBody] RequestType Request)
        {
            var _result = await this._repo.UpdateRequestType(Request);

            return Ok(_result);

        }

        [HttpDelete("RemoveRequest")]
        public async Task<IActionResult> RemoveRequest(int request_type_id)
        {
            var _result = await this._repo.RemoveRequestType(request_type_id);

            return Ok(_result);

        }
    }
}

