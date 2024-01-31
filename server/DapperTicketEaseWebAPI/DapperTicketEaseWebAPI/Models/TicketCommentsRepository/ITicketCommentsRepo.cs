namespace DapperTicketEaseWebAPI.Models.TicketCommentsRepository
{
    public interface ITicketCommentsRepo
    {
        //public Task<string> UpdateTicket(Ticket ticket);
        public Task<List<TicketComments>> GetTicketCommentsForTicket(int ticket_id);

    }
}
