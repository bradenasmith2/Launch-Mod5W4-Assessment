using GalaxyQuest.Models;
namespace GalaxyQuest.Interfaces
{
    public interface IFarFarAwayGalaxy
    {
        Task<List<FarFarAwayPlanet>> GetFarFarAwayPlanets();
    }
}
