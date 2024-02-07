namespace DapperTicketEaseWebAPI.Models.TicketRepository
{
    public interface ITicketRepo
    {
        public Task<List<Ticket>> GetAllTickets();

        public Task<List<Ticket>> GetAllIncidentTickets();

        public Task<List<Ticket>> GetAllRequestTickets();

        public Task<Ticket> GetTicketById(string ticket_id);        

        public Task<string> GetAllIncidentTicketsByEmpId(string emp_id);

        public Task<string> GetAllRequestTicketsByEmpId(string emp_id);

        public Task<string> CreateTicket(Ticket ticket);

        public Task<string> UpdateTicket(Ticket ticket);

        public Task<string> RemoveTicket(string ticket_id);

        public Task<List<Ticket>> GetAllTicketsByPriority();

        public Task<List<Ticket>> GetAllTicketsByCreationDate();

        public Task<List<Ticket>> GetAllTicketsDeptWiseByPriority(string dept_id, string priority);
    }
}
