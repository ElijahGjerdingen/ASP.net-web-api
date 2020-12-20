using IdentityModel.Client;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Esports.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
                var discoveryDocument = await client.GetDiscoveryDocumentAsync(
                    "http://localhost:61331");

            var tokenResponse = await client.RequestClientCredentialsTokenAsync(
                new ClientCredentialsTokenRequest
                {
                    Address = discoveryDocument.TokenEndpoint,
                    ClientId = "client",
                    ClientSecret = "ESport",
                    Scope = "es-api"
                });
            
            Console.WriteLine($"Token: {tokenResponse.AccessToken}");
        }
    }
}
