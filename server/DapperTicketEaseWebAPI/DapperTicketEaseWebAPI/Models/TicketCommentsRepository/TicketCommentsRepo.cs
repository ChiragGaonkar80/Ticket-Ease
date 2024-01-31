using Dapper;
using DapperTicketEaseWebAPI.Models.Data;

namespace DapperTicketEaseWebAPI.Models.TicketCommentsRepository
{
    public class TicketCommentsRepo : ITicketCommentsRepo
    {
        private readonly DapperDBContext context;

        public TicketCommentsRepo(DapperDBContext context)
        {
            this.context = context;
        }


        /*public async Task<string> UpdateTicket(Ticket ticket)
        {
            string response = string.Empty;
            string query = "Update ticket set ticket_id=@ticket_id, title=@title, description=@description, emp_id=@emp_id, dept_id=@dept_id, admin_id=@admin_id, manager_id=@manager_id, status_id=@status_id, created_on=@created_on, updated_on=@updated_on, need_approval=@need_approval;";
            var parameters = new DynamicParameters();

            parameters.Add("ticket_id", ticket.ticket_id, System.Data.DbType.Int64);
            parameters.Add("title", ticket.title, System.Data.DbType.String);
            parameters.Add("description", ticket.description, System.Data.DbType.String);
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
        }*/
        public async Task<List<TicketComments>> GetTicketCommentsForTicket(int ticket_id)
        {
            using (var connection = context.CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ticket_id", ticket_id, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);

                var result = await connection.QueryAsync<TicketComments>("GetTicketCommentsForTicket", parameters, commandType: System.Data.CommandType.StoredProcedure);
                return result.ToList();
            }
        }
    }
}
