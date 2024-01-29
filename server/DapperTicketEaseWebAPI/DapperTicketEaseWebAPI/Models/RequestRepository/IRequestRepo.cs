namespace DapperTicketEaseWebAPI.Models.Repo
{
    public interface IRequestRepo
    {
        public Task<List<Request>> GetAllRequests();

        public Task<string> CreateRequest(Request request);

        public Task<string> UpdateRequest(Request request);

        public Task<string> RemoveRequest(string request_type);

    }
}
