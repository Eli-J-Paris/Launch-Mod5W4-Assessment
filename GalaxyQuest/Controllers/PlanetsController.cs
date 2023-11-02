using GalaxyQuest.Interfaces;
using GalaxyQuest.Services;
using Microsoft.AspNetCore.Mvc;

namespace GalaxyQuest.Controllers
{
    public class PlanetsController : Controller
    {
        private readonly IStarwarsApi _starwarsApiService;

        public PlanetsController(IStarwarsApi starwarsApiService)
        {
            _starwarsApiService = starwarsApiService;
        }
        public async Task<IActionResult> Index()
        {
            var milkyWayPlanets = MilkyWayGalaxy.Planets;

            var starwarsPlants = await _starwarsApiService.GetStarwarsPlanets();
            
            return View(starwarsPlants);
        }

    }
}
