using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Nightclub.Productions;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses
{
    class StocksProductionLogicFactory
    {
        public static StocksProductionLogic CreateByMCType(MCBuisnessType type)
        {
            return type switch
            {
                MCBuisnessType.CounterfeitCashFactory => new StocksProductionLogic(50, 40, TimeSpan.FromSeconds(12)),
                MCBuisnessType.DocumentForgeryOffice => new StocksProductionLogic(25/6, 60, TimeSpan.FromSeconds(5)),
                MCBuisnessType.WeedFarm => new StocksProductionLogic(62.5, 80, TimeSpan.FromSeconds(6)),
                MCBuisnessType.MethamphetamineLab => new StocksProductionLogic(40, 20, TimeSpan.FromSeconds(30)),
                MCBuisnessType.CocaineLockup => new StocksProductionLogic(40, 10, TimeSpan.FromSeconds(50)),

                _ => throw new ArgumentException("Unknown warehouse name.", nameof(type))
            };
        }
        public static StocksProductionLogic CreateForBunker()
        {
            return new StocksProductionLogic(20, 100, TimeSpan.FromSeconds(10));
        }
    }
}
