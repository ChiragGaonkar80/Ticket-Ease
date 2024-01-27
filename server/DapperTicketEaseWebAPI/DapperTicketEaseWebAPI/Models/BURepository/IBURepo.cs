namespace DapperTicketEaseWebAPI.Models.BURepo
{
    public interface IBURepo
    {
        public Task<List<BU>> GetAllBUs();

        public Task<string> CreateBU(BU bu);

        public Task<string> UpdateBU(BU bu);

        public Task<string> RemoveBU(int id);

    }
}
