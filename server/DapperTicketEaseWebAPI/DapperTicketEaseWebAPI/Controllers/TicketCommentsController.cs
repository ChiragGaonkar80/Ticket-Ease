using Microsoft.AspNetCore.Mvc;
using DapperTicketEaseWebAPI.Models.TicketCommentsRepository;
using DapperTicketEaseWebAPI.Models;
using Azure;
using System;


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

        [HttpPost("CreateTicketComment")]
        public async Task<IActionResult> CreateTicketComment([FromBody] TicketComment ticketComment)
        {
            var _result = await this.repo.CreateTicketComment(ticketComment);
            return Ok(_result);

        }

        [HttpPut("UpdateTicketComment")]
        public async Task<IActionResult> UpdateTicketComment([FromBody] TicketComment ticketComment)
        {
            var _result = await this.repo.UpdateTicketComment(ticketComment);
            return Ok(_result);

        }

        [HttpDelete("RemoveTicketComment")]
        public async Task<IActionResult> RemoveTicketComment(string comment_id)
        {
            var _result = await this.repo.RemoveTicketComment(comment_id);
            return Ok(_result);


        }

        [HttpGet("GetTicketCommentsForTicket")]
        public async Task<IActionResult> GetTicketCommentsForTicket(string ticket_id)
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

        [HttpPut("UpdateTicketStatusandAddComments")]
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
