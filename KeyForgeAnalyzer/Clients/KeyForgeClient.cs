using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace KeyForgeAnalyzer
{
    public class KeyForgeClient
    {
        private readonly HttpClient _client;
        private ILogger<KeyForgeClient> _logger;

        public KeyForgeClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<string> GetCards(string id)
        {
            try
            {
                var response = await _client.GetAsync(id);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError($"An error occured connecting to values API {ex.ToString()}");
                return string.Empty;
            }
        }
    }
}
