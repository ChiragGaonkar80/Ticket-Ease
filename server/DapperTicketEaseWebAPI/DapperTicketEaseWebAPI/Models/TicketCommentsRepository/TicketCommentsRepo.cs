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

        private string GenerateCommentId()
        {
            Guid g = Guid.NewGuid();
            string id = "tktcmnts_" + g.ToString();
            return id;
        }

        public async Task<string> CreateTicketComment(TicketComment ticket)
        {
            string response = string.Empty;
            string query = "Insert into ticketcomments(comment_id, description, ticket_id, status_title,created_on,updated_on) values (@comment_id, @description, @ticket_id, @status_title,@created_on,@updated_on);";
            var parameters = new DynamicParameters();

            parameters.Add("comment_id", GenerateCommentId(), System.Data.DbType.String);
            parameters.Add("description", ticket.description, System.Data.DbType.String);
            parameters.Add("ticket_id", ticket.ticket_id, System.Data.DbType.String);
            parameters.Add("status_title", ticket.status_title, System.Data.DbType.String);
            parameters.Add("created_on", ticket.created_on, System.Data.DbType.Date);
            parameters.Add("updated_on", ticket.updated_on, System.Data.DbType.Date);

            using (var connection = context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
                response = "pass";
            }

            return response;
        }

        public async Task<List<TicketComment>> GetTicketCommentsForTicket(string ticket_id)
        {
            using (var connection = context.CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ticket_id", ticket_id, System.Data.DbType.String, System.Data.ParameterDirection.Input);

                var result = await connection.QueryAsync<TicketComment>("GetTicketCommentsForTicket", 
                    parameters, commandType: System.Data.CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<string> UpdateTicketStatusandAddComments(UpdateStatusAddComment t)
        {

            string response = string.Empty;
            try
            {
                var parameters = new DynamicParameters();

                parameters.Add("@ticket_id", t.ticket_id, System.Data.DbType.String);
                parameters.Add("@status_title", t.status_title, System.Data.DbType.String);
                parameters.Add("@comment", t.comment, System.Data.DbType.String);

                using (var connection = context.CreateConnection())
                {
                    await connection.ExecuteAsync("UpdateTicketStatusandAddComments", parameters, commandType: System.Data.CommandType.StoredProcedure);
                }
                response = "pass";
            } catch (Exception ex)
            {
                response = $"Error: {ex.Message}";
            }
            return response;
        }

        public async Task<string> UpdateTicketComment(TicketComment ticket)
        {
            string response = string.Empty;
            string query = "Update ticketcomments set  description=@description, ticket_id=@ticket_id, status_title=@status_title,created_on=@created_on,updated_on=@updated_on where comment_id=@comment_id;";
            var parameters = new DynamicParameters();

            parameters.Add("comment_id", GenerateCommentId(), System.Data.DbType.String);
            parameters.Add("description", ticket.description, System.Data.DbType.String);
            parameters.Add("ticket_id", ticket.ticket_id, System.Data.DbType.String);
            parameters.Add("status_title", ticket.status_title, System.Data.DbType.String);
            parameters.Add("created_on", ticket.created_on, System.Data.DbType.Date);
            parameters.Add("updated_on", ticket.updated_on, System.Data.DbType.Date);

            using (var connection = context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
                response = "pass";
            }

            return response;
        }

        public async Task<string> RemoveTicketComment(string comment_id)
        {
            string response = string.Empty;
            string query = "Delete from ticketcomments where comment_id=@comment_id";
            var parameters = new DynamicParameters();

            parameters.Add("comment_id", comment_id, System.Data.DbType.String);

            using (var connection = context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
                response = "pass";
            }

            return response;
        }
    }
}
