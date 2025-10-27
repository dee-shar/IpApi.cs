using System.Net.Http;
using System.Net.Http.Headers;

namespace IPGeolocationApi
{
    public class IpApi
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "http://ip-api.com";
        public IpApi()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36");
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> GetIpInfo(string ip)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/json/{ip}");
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetMyIp()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/json");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
