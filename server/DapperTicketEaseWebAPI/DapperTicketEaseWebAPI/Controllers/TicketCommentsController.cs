using Microsoft.AspNetCore.Mvc;
using DapperTicketEaseWebAPI.Models.TicketCommentsRepository;
using DapperTicketEaseWebAPI.Models;


namespace DapperTicketEaseWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketCommentsController : ControllerBase
    {
        private readonly ITicketCommentsRepo repo;

        public TicketCommentsController(ITicketCommentsRepo repo)
        {
            this.repo = repo;
        }
        [HttpGet("GetTicketCommentsForTicket")]
        public async Task<IActionResult> GetTicketCommentsForTicket(int ticket_id)
        {
            var ticketComments = await this.repo.GetTicketCommentsForTicket(ticket_id);
            if (ticketComments != null && ticketComments.Any())
            {
                return Ok(ticketComments);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost("UpdateTicketStatusandAddComments")]
        public async Task<IActionResult> UpdateTicketStatusandAddComments([FromBody] UpdateStatusAddComment us)
        {
            var _result = await this.repo.UpdateTicketStatusandAddComments(us);
            if (_result == "pass")
            {
            return Ok(_result);
            }
            else
            {
                return BadRequest($"Error Updating Ticket Status{_result}");
            }

        }

    }
}
