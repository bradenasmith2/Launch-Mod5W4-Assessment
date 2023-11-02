using GalaxyQuest.Interfaces;
using System.Net.Http.Headers;
using System.Text.Json;
using GalaxyQuest.Models;

namespace GalaxyQuest.Services
{
    public class FarFarAwayGalaxy : IFarFarAwayGalaxy
    {
        private static readonly HttpClient Client;

        static FarFarAwayGalaxy()
        {
            Client = new HttpClient() { BaseAddress = new Uri("https://swapi.dev") };//if '/api' is added here, the connection is never made.
            Client.DefaultRequestHeaders.UserAgent.Add(
                new ProductInfoHeaderValue("GalaxyQuest", "1.0")
            );
        }

        public async Task<List<FarFarAwayPlanet>> GetFarFarAwayPlanets()
        {
            string url = "/api/planets";
            var result = new List<FarFarAwayPlanet>();
            var response = await Client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var stringresponse = await response.Content.ReadAsStringAsync();
                result = JsonSerializer.Deserialize<List<FarFarAwayPlanet>>(stringresponse, new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }

            return result;
        }
    }
}