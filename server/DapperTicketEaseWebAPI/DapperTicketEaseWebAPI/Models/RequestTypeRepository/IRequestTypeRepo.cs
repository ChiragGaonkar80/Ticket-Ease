namespace DapperTicketEaseWebAPI.Models.Repo
{
    public interface IRequestTypeRepo
    {
        public Task<List<RequestType>> GetAllRequestTypes();

        public Task<RequestType> GetRequestTypeById(int request_type_id);

        public Task<List<RequestType>> GetRequestTypesByDeptId(int dept_id);

        public Task<string> CreateRequestType(RequestType request);

        public Task<string> UpdateRequestType(RequestType request);

        public Task<string> RemoveRequestType(int request_type_id);

    }
}
