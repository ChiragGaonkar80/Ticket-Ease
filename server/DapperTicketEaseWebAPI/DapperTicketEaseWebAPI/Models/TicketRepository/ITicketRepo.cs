namespace DapperTicketEaseWebAPI.Models.TicketRepository
{
    public interface ITicketRepo
    {
        public Task<List<Ticket>> GetAllTickets();

        public Task<string> CreateTicket(Ticket ticket);

        public Task<string> UpdateTicket(Ticket ticket);

        public Task<string> RemoveTicket(int id);

        public Task<List<Ticket>> GetAllTicketsByPriority();
    }
}
