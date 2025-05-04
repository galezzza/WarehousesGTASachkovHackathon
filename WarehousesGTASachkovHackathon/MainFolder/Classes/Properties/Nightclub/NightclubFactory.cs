using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Bunker;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Nightclub
{
    class NightclubFactory
    {
        public static Nightclub CreateByName(string name)
        {
            return name switch
            {
                "DelPerroNightclub" => new Nightclub("Del Perro Nightclub", 1645000),
                "VespucciCanalsNightclub" => new Nightclub("Vespucci Canals Nightclub", 1320000),
                "StrawberryNightclub" => new Nightclub("Strawberry Nightclub", 1135000),
                "LSIANightclub" => new Nightclub("LSIA Nightclub", 1440000),
                "MissionRowNightclub" => new Nightclub("Mission Row Nightclub", 1500000),
                "LaMesaNightclub" => new Nightclub("La Mesa Nightclub", 1370000),
                "CypressFlatsNightclub" => new Nightclub("Cypress Flats Nightclub", 1700000),
                "WestVinewoodNightclub" => new Nightclub("West Vinewood Nightclub", 1670000),
                "ElusianIslandNightclub" => new Nightclub("Elusian Island Nightclub", 1080000),
                _ => throw new ArgumentException("Unknown warehouse name.", nameof(name))
            };
        }

        public static IReadOnlyList<string> GetAvailableWarehouseNames()
        => new List<string>
                {
                    "DelPerroNightclub",
                    "VespucciCanalsNightclub",
                    "StrawberryNightclub",
                    "LSIANightclub",
                    "MissionRowNightclub",
                    "LaMesaNightclub",
                    "CypressFlatsNightclub",
                    "WestVinewoodNightclub",
                    "ElusianIslandNightclub",
                };
    }
}
