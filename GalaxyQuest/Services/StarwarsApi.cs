using GalaxyQuest.Interfaces;
using GalaxyQuest.Models;
using System.Text.Json;

namespace GalaxyQuest.Services
{
    public class StarwarsApi : IStarwarsApi
    {
        private static readonly HttpClient Client;

        static StarwarsApi()
        {
            Client = new HttpClient()
            {
                BaseAddress = new Uri("https://swapi.dev/api/")
            };
        }

        public async Task<List<Planet>> GetStarwarsPlanets()
        {
            var url = "planets/";
            var result = new List<Planet>();
            var response = await Client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

           
                result = JsonSerializer.Deserialize<List<Planet>>(stringResponse,
                    new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);

            }
            return result;
        }
    }
}
