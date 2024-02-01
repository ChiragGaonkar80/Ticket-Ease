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

        public async Task<List<TicketComments>> GetTicketCommentsForTicket(int ticket_id)
        {
            using (var connection = context.CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ticket_id", ticket_id, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);

                var result = await connection.QueryAsync<TicketComments>("GetTicketCommentsForTicket", 
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
    }
}
