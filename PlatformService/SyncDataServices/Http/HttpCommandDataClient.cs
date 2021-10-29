using PlatformService.Dtos;
using System.Text;
using System.Text.Json;

namespace PlatformService.SyncDataServices.Http
{
    public class HttpCommandDataClient : ICommandDataClient
    {
        private readonly HttpClient _httpClient;

        public HttpCommandDataClient(HttpClient httpClient )
        {
            _httpClient = httpClient;
        }
        public async Task SendPlatformToCommand(PlatformReadDto plat)
        {
            var httpContetn = new StringContent(
                JsonSerializer.Serialize(plat),
                Encoding.UTF8,
                "application/json"
                );
            var response = await _httpClient.PostAsync("",httpContetn);

            if(response.IsSuccessStatusCode)
            {
                Console.WriteLine("This is success");
            }
        }
    }
}
