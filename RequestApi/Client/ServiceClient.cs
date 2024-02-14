using RequestApi.Models;
using RestSharp;

namespace RequestApi.Client
{
    public class ServiceClient : IServiceClient
    {
        public async Task<List<User>> GetAllUser()
        {
            var client = new RestClient("https://localhost:7156");
            var request = new RestRequest("/api/User", Method.Get);

            try
            {
                var response = await client.ExecuteAsync<List<User>>(request);

                if (response.IsSuccessful)
                {
                    return response.Data;
                }
                else
                {
                    throw new Exception($"Hata Kodu : {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception", ex);
            }
        }
    }
}
