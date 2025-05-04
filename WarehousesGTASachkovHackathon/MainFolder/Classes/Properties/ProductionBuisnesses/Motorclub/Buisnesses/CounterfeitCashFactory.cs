using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub.Buisnesses
{
    class CounterfeitCashFactory : MCProductionBuisness
    {
        public CounterfeitCashFactory(string name, int price) 
            : base(name, price, MCBuisnessType.CounterfeitCashFactory)
        {
        }

        public override IOwnedProperty AddOwner(Player player)
        {
            return new OwnedCounterfeitCashFactory(this, player);
        }
    }
}
