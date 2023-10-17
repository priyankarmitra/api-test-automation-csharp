

namespace VerivoxTestApiProject.Services
{
    public class ApiServices
    {
        private RestClient restClient;

        public ApiServices(string uri)
        {
            restClient = new RestClient(uri);
        }

        public async Task<RestResponse> GetData(string resourcePath)
        {
            var request = new RestRequest(resourcePath, Method.Get);
            var response = await restClient.ExecuteAsync(request);
            return response;
        }

        public async Task<RestResponse> PostData(string resourcePath, string requestBody)
        {
            var request = new RestRequest(resourcePath, Method.Post);
            request.AddJsonBody(requestBody);
            var response = await restClient.ExecuteAsync(request);
            return response;
        }
    }
}
