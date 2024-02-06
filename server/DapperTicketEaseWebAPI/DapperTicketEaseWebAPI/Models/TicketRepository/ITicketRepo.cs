﻿namespace DapperTicketEaseWebAPI.Models.TicketRepository
{
    public interface ITicketRepo
    {
        public Task<List<Ticket>> GetAllTickets();

        public Task<List<Ticket>> GetAllIncidentTickets();

        public Task<List<Ticket>> GetAllRequestTickets();

        public Task<List<IncidentTickets>> GetAllIncidentTicketsByEmpId(int emp_id);

        public Task<List<RequestTickets>> GetAllRequestTicketsByEmpId(int emp_id);

        public Task<string> CreateTicket(Ticket ticket);

        public Task<string> UpdateTicket(Ticket ticket);

        public Task<string> RemoveTicket(int id);

        public Task<List<Ticket>> GetAllTicketsByPriority();

        public Task<List<Ticket>> GetAllTicketsByCreationDate();

        public Task<List<Ticket>> GetAllTicketsDeptWiseByPriority(int id, int priority);
    }
}
