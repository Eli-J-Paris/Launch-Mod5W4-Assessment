using GalaxyQuest.Models;

namespace GalaxyQuest.Interfaces
{
    public interface IStarwarsApi
    {
        Task<List<Planet>> GetStarwarsPlanets();
    }
}
