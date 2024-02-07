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

        [HttpGet("GetTicketById")]
        public async Task<IActionResult> GetTicketById(string ticket_id)
        {
            var _list = await this.repo.GetTicketById(ticket_id);
            if (_list != null)
            {
                return Ok(_list);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("GetAllIncidentTickets")]
        public async Task<IActionResult> GetAllIncidentTickets()
        {
            var _list = await this.repo.GetAllIncidentTickets();
            if (_list != null)
            {
                return Ok(_list);
            }
            else
            {
                return NotFound();
            }

        }


        [HttpGet("GetAllRequestTickets")]
        public async Task<IActionResult> GetAllRequestTickets()
        {
            var _list = await this.repo.GetAllRequestTickets();
            if (_list != null)
            {
                return Ok(_list);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("GetAllIncidentTicketsByEmpId")]
        public async Task<IActionResult> GetAllIncidentTicketsByEmpId( string emp_id)
        {
            var _list = await this.repo.GetAllIncidentTicketsByEmpId(emp_id);
            if (_list != null)
            {
                return Ok(_list);
            }
            else
            {
                return NotFound();
            }

        }


        [HttpGet("GetAllRequestTicketsByEmpId")]
        public async Task<IActionResult> GetAllRequestTicketsByEmpId( string emp_id)
        {
            var _list = await this.repo.GetAllRequestTicketsByEmpId(emp_id);
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

        [HttpPut("UpdateTicket")]
        public async Task<IActionResult> UpdateTicket([FromBody] Ticket ticket)
        {
            var _result = await this.repo.UpdateTicket(ticket);

            return Ok(_result);

        }

        [HttpDelete("RemoveTicket")]
        public async Task<IActionResult> RemoveTicket(string ticket_id)
        {
            var _result = await this.repo.RemoveTicket(ticket_id);

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

        [HttpGet("GetAllTicketsByCreationDate")]
        public async Task<IActionResult> GetAllTicketsByCreationDate()
        {
            var _list = await this.repo.GetAllTicketsByCreationDate();
            if (_list != null)
            {
                return Ok(_list);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("GetAllTicketsDeptWiseByPriority")]
        public async Task<IActionResult> GetAllTicketsDeptWiseByPriority(string dept_id, int priority)
        {
            var _list = await this.repo.GetAllTicketsDeptWiseByPriority(dept_id, priority);
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
