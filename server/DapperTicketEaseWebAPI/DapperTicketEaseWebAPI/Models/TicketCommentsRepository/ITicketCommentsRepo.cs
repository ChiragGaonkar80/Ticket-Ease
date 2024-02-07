namespace DapperTicketEaseWebAPI.Models.TicketCommentsRepository
{
    public interface ITicketCommentsRepo
    {
        //public Task<string> UpdateTicket(Ticket ticket);
        public Task<string> CreateTicketComment(TicketComment ticket);
        public Task<string> UpdateTicketComment(TicketComment ticket);
        public Task<string> RemoveTicketComment(string comment_id);
        public Task<List<TicketComment>> GetTicketCommentsForTicket(string ticket_id);
        public Task<string> UpdateTicketStatusandAddComments(UpdateStatusAddComment t);
    }
}
