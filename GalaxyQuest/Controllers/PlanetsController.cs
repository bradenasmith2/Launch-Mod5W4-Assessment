using GalaxyQuest.Interfaces;
using GalaxyQuest.Services;
using Microsoft.AspNetCore.Mvc;

namespace GalaxyQuest.Controllers
{
    public class PlanetsController : Controller
    {
        private readonly IFarFarAwayGalaxy _FarFarAwayApiService;

        public PlanetsController(IFarFarAwayGalaxy farAwayApiService)
        {
            _FarFarAwayApiService = farAwayApiService;
        }
        public async Task<IActionResult> Index()
        {
            var milkyWayPlanets = MilkyWayGalaxy.Planets;
            ViewBag.FarFarAwayPlanets = await _FarFarAwayApiService.GetFarFarAwayPlanets();
            
            return View(milkyWayPlanets);
        }
    }
}
