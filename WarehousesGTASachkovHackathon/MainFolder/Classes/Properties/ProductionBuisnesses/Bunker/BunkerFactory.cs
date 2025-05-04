using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Bunker
{
    class BunkerFactory
    {
        public static Bunker CreateByName(string name)
        {
            return name switch
            {
                "PaletoForestBunker" => new Bunker("Paleto Forest Bunker", 1165000),
                "RatonCanyonBunker" => new Bunker("Raton Canyon Bunker", 1450000),
                "LagoZancudoBunker" => new Bunker("Lago Zancudo Bunker", 1550000),
                "ChumashBunker" => new Bunker("Chumash Bunker", 1650000),
                "GrapeseedBunker" => new Bunker("Grapeseed Bunker", 1750000),
                "Route68Bunker" => new Bunker("Route 68 Bunker", 1950000),
                "GrandSenoraOilfieldsBunker" => new Bunker("Grand Senora Oil fields bunker", 2035000),
                "GrandSenoraDesertBunker" => new Bunker("Grand Senora Desert Bunker", 2120000),
                "SmokeTreeRoadBunker" => new Bunker("Smoke Tree Road Bunker", 2205000),
                "ThomsonScrapyardBunker" => new Bunker("Thomson Scrapyard Bunker", 2290000),
                "FarmhouseBunker" => new Bunker("Farmhouse Bunker", 2375000),
                _ => throw new ArgumentException("Unknown warehouse name.", nameof(name))
            };
        }

        public static IReadOnlyList<string> GetAvailableWarehouseNames()
        => new List<string>
                {
                    "PaletoForestBunker",
                    "RatonCanyonBunker",
                    "LagoZancudoBunker",
                    "ChumashBunker",
                    "GrapeseedBunker",
                    "Route68Bunker",
                    "GrandSenoraOilfieldsBunker",
                    "GrandSenoraDesertBunker",
                    "SmokeTreeRoadBunker",
                    "ThomsonScrapyardBunker",
                    "FarmhouseBunker"
                };
    }

    }
