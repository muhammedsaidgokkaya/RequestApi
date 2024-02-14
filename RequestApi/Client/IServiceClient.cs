using RequestApi.Models;

namespace RequestApi.Client
{
    public interface IServiceClient
    {
        Task<List<User>> GetAllUser();
    }
}
