using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Motorclub
{
    class StocksProductionLogicFactory
    {
        public static StocksProductionLogic CreateByType(MCBuisnessesType type)
        {
            return type switch
            {
                MCBuisnessesType.CounterfeitCashFactory => new StocksProductionLogic(50, 40, TimeSpan.FromSeconds(12)),
                MCBuisnessesType.DocumentForgeryOffice => new StocksProductionLogic(25/6, 60, TimeSpan.FromSeconds(5)),
                MCBuisnessesType.WeedFarm => new StocksProductionLogic(62.5, 80, TimeSpan.FromSeconds(6)),
                MCBuisnessesType.MethamphetamineLab => new StocksProductionLogic(40, 20, TimeSpan.FromSeconds(30)),
                MCBuisnessesType.CocaineLockup => new StocksProductionLogic(40, 10, TimeSpan.FromSeconds(50)),

                _ => throw new ArgumentException("Unknown warehouse name.", nameof(type))
            };
        }
    }
}
