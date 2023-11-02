using GalaxyQuest.Models;

namespace GalaxyQuest.Services
{
    public class MilkyWayGalaxy
    {
        static public List<MilkyWayPlanet> Planets = new List<MilkyWayPlanet>() {
            new MilkyWayPlanet() { Name = "Mercury", Population = 1 },
            new MilkyWayPlanet() { Name = "Venus", Population = 2 },
            new MilkyWayPlanet() { Name = "Earth", Population = 7_888_000_000 },
            new MilkyWayPlanet() { Name = "Mars", Population = 3 },
            new MilkyWayPlanet() { Name = "Jupiter", Population = 1 },
            new MilkyWayPlanet() { Name = "Saturn", Population = 1 },
            new MilkyWayPlanet() { Name = "Uranus", Population = 0 },
            new MilkyWayPlanet() { Name = "Neptune", Population = 0 }
        };
    }
}
