
using Dapper;
using DapperTicketEaseWebAPI.Models.Data;

namespace DapperTicketEaseWebAPI.Models.TicketRepository
{
    public class TicketRepo : ITicketRepo
    {
        private readonly DapperDBContext context;

        public TicketRepo(DapperDBContext context)
        {
            this.context = context;
        }

        public async Task<string> CreateTicket(Ticket ticket)
        {
            string response = string.Empty;
            string query = "Insert into ticket(ticket_id,title,description,emp_id,dept_id,admin_id,manager_id,status_id,created_on,updated_on,need_approval) values (@ticket_id,@title,@description,@emp_id,@dept_id,@admin_id,@manager_id,@status_id,@created_on,@updated_on,@need_approval);";
            var parameters = new DynamicParameters();

            parameters.Add("ticket_id", ticket.ticket_id, System.Data.DbType.Int64);
            parameters.Add("title", ticket.title, System.Data.DbType.String);
            parameters.Add("description", ticket.formdata, System.Data.DbType.String);
            parameters.Add("emp_id", ticket.emp_id, System.Data.DbType.Int64);
            parameters.Add("dept_id", ticket.dept_id, System.Data.DbType.Int64);
            parameters.Add("admin_id", ticket.admin_id, System.Data.DbType.Int64);
            parameters.Add("manager_id", ticket.manager_id, System.Data.DbType.Int64);
            parameters.Add("status_id", ticket.status_id, System.Data.DbType.String);
            parameters.Add("created_on", ticket.created_on, System.Data.DbType.Date);
            parameters.Add("updated_on", ticket.updated_on, System.Data.DbType.Date);
            parameters.Add("need_approval", ticket.need_approval, System.Data.DbType.Boolean);

            using (var connection = context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
                response = "pass";
            }

            return response;
        }

        public async Task<List<Ticket>> GetAllTickets()
        {
            string query = "Select * from ticket t inner join ticketstatus ts on t.status_id = ts.status_id;";
            using (var connection = context.CreateConnection())
            {
                var ticketlist = await connection.QueryAsync<Ticket>(query);
                return ticketlist.ToList();

            }
        }



        public async Task<List<Ticket>> GetAllIncidentTickets()
        {
            string query = "Select * from ticket t inner join ticketstatus ts on t.status_id = ts.status_id where request_type_id in ((select request_type_id from requestTypes where is_incident = 1);";
            using (var connection = context.CreateConnection())
            {
                var ticketlist = await connection.QueryAsync<Ticket>(query);
                return ticketlist.ToList();

            }
        }

        public async Task<List<Ticket>> GetAllRequestTickets()
        {
            string query = "Select * from ticket t inner join ticketstatus ts on t.status_id = ts.status_id where request_type_id in (select request_type_id from requestTypes where is_incident = 0);";
            using (var connection = context.CreateConnection())
            {
                var ticketlist = await connection.QueryAsync<Ticket>(query);
                return ticketlist.ToList();

            }
        }

        public async Task<string> RemoveTicket(int id)
        {
            string response = string.Empty;
            string query = "Delete from ticket where ticket_id=@ticket_id";
            var parameters = new DynamicParameters();

            parameters.Add("ticket_id", id, System.Data.DbType.Int64);

            using (var connection = context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
                response = "pass";
            }

            return response;
        }

        public async Task<string> UpdateTicket(Ticket ticket)
        {
            string response = string.Empty;
            string query = "Update ticket set ticket_id=@ticket_id, title=@title, formdata=@formdata, emp_id=@emp_id, dept_id=@dept_id, admin_id=@admin_id, manager_id=@manager_id, status_id=@status_id, created_on=@created_on, updated_on=@updated_on, need_approval=@need_approval;";
            var parameters = new DynamicParameters();

            parameters.Add("ticket_id", ticket.ticket_id, System.Data.DbType.Int64);
            parameters.Add("title", ticket.title, System.Data.DbType.String);
            parameters.Add("formdata", ticket.formdata, System.Data.DbType.String);
            parameters.Add("emp_id", ticket.emp_id, System.Data.DbType.Int64);
            parameters.Add("dept_id", ticket.dept_id, System.Data.DbType.Int64);
            parameters.Add("admin_id", ticket.admin_id, System.Data.DbType.Int64);
            parameters.Add("manager_id", ticket.manager_id, System.Data.DbType.Int64);
            parameters.Add("status_id", ticket.status_id, System.Data.DbType.String);
            parameters.Add("created_on", ticket.created_on, System.Data.DbType.Date);
            parameters.Add("updated_on", ticket.updated_on, System.Data.DbType.Date);
            parameters.Add("need_approval", ticket.need_approval, System.Data.DbType.Boolean);


            using (var connection = context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
                response = "pass";
            }


            return response;
        }

        public async Task<List<Ticket>> GetAllTicketsByPriority()
        {
            string query = "Select * from ticket t inner join ticketstatus ts on t.status_id = ts.status_id order by t.priority;";
            using (var connection = context.CreateConnection())
            {
                var ticketlist = await connection.QueryAsync<Ticket>(query);
                return ticketlist.ToList();

            }
        }

        public async Task<List<Ticket>> GetAllTicketsByCreationDate()
        {
            string query = "Select * from ticket t inner join ticketstatus ts on t.status_id = ts.status_id order by t.created_on;";
            using (var connection = context.CreateConnection())
            {
                var ticketlist = await connection.QueryAsync<Ticket>(query);
                return ticketlist.ToList();

            }
        }

        public async Task<List<Ticket>> GetAllTicketsDeptWiseByPriority(int id, int priority)
        {
            string query = "Select * from ticket t inner join ticketstatus ts on t.status_id = ts.status_id where dept_id=@dept_id and priority=@priority;";
            var parameters = new DynamicParameters();

            parameters.Add("dept_id", id, System.Data.DbType.Int64);
            parameters.Add("priority", priority, System.Data.DbType.Int64);
            using (var connection = context.CreateConnection())
            {
                var ticketlist = await connection.QueryAsync<Ticket>(query, parameters);
                return ticketlist.ToList();
            }
        }

        public async Task<List<Ticket>> GetAllIncidentTicketsByEmpId(int emp_id)
        {
            string query = "Select * from ticket t inner join ticketstatus ts on t.status_id = ts.status_id where emp_id=@emp_id and request_type_id in (select request_type_id from requestTypes where is_incident = 1);";
            var parameters = new DynamicParameters();

            parameters.Add("emp_id", emp_id, System.Data.DbType.Int64);
            using (var connection = context.CreateConnection())
            {
                var ticketlist = await connection.QueryAsync<Ticket>(query, parameters);
                return ticketlist.ToList();

            }
        }

        public async Task<List<Ticket>> GetAllRequestTicketsByEmpId(int emp_id)
        {
            string query = "Select * from ticket t inner join ticketstatus ts on t.status_id = ts.status_id where emp_id=@emp_id and request_type_id in (select request_type_id from requestTypes where is_incident = 0);";
            var parameters = new DynamicParameters();

            parameters.Add("emp_id", emp_id, System.Data.DbType.Int64);
            using (var connection = context.CreateConnection())
            {
                var ticketlist = await connection.QueryAsync<Ticket>(query, parameters);
                return ticketlist.ToList();

            }
        }
    }
}
