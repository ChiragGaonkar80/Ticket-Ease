using Microsoft.AspNetCore.Mvc;
using DapperTicketEaseWebAPI.Models.TicketCommentsRepository;


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

        /*[HttpPost("UpdateTicketComments")]
        public async Task<IActionResult> UpdateTicket([FromBody] Ticket ticket)
        {
            var _result = await this.repo.UpdateTicket(ticket);

            return Ok(_result);

        }*/
    }
}
