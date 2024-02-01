using DapperTicketEaseWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DapperTicketEaseWebAPI.Models.TicketRepository;

namespace DapperTicketEaseWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketRepo repo;

        public TicketController(ITicketRepo repo)
        {
            this.repo = repo;
        }


        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var _list = await this.repo.GetAllTickets();
            if (_list != null)
            {
                return Ok(_list);
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost("CreateTicket")]
        public async Task<IActionResult> CreateTicket([FromBody] Ticket ticket)
        {
            var _result = await this.repo.CreateTicket(ticket);

            return Ok(_result);

        }

        [HttpPost("UpdateTicket")]
        public async Task<IActionResult> UpdateTicket([FromBody] Ticket ticket)
        {
            var _result = await this.repo.UpdateTicket(ticket);

            return Ok(_result);

        }

        [HttpPost("RemoveTicket")]
        public async Task<IActionResult> RemoveTicket(int id)
        {
            var _result = await this.repo.RemoveTicket(id);

            return Ok(_result);

        }

        [HttpGet("GetAllTicketsByPriority")]
        public async Task<IActionResult> GetAllTicketsByPriority()
        {
            var _list = await this.repo.GetAllTicketsByPriority();
            if (_list != null)
            {
                return Ok(_list);
            }
            else
            {
                return NotFound();
            }

        }
    }
}
