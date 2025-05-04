using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Bunker;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Hangar
{
    class HangarFactory
    {
        public static Hangar CreateByName(string name)
        {
            return name switch
            {
                "LSIA Hangar A17" => new Hangar("LSIA Hangar A17", 1200000),
                "LSIA Hangar 1" => new Hangar("LSIA Hangar 1", 1525000),
                "Fort Zancudo Hangar 3499" => new Hangar("Fort Zancudo Hangar 3499", 2650000),
                "Fort Zancudo Hangar 3497" => new Hangar("Fort Zancudo Hangar 3497", 2085000),
                "Fort Zancudo Hangar A2" => new Hangar("Fort Zancudo Hangar A2", 3250000),
                _ => throw new ArgumentException("Unknown warehouse name.", nameof(name))
            };
        }

        public static IReadOnlyList<string> GetAvailableWarehouseNames()
        => new List<string>
                {
                    "LSIA Hangar A17",
                    "LSIA Hangar 1",
                    "Fort Zancudo Hangar 3499",
                    "Fort Zancudo Hangar 3497",
                    "Fort Zancudo Hangar A2",
                };
    }
}
