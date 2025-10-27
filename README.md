# IpApi.cs
Web-API for [ip-api.com] an fast, accurate, reliable IP Geolocation API

## Example
```cs
using IPGeolocationApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new IpApi();
            string ipInfo = await api.GetMyIp();
            Console.WriteLine(ipInfo);
        }
    }
}
```
