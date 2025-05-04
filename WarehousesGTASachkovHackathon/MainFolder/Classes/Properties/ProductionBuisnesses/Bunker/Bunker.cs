using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Bunker
{
    class Bunker : ProductionBuisness
    {
        public Bunker(string name, int price)
        : base(name, price)
        {
        }

        public override IOwnedProperty AddOwner(Player player)
        {
            return new OwnedBunker(this, player);
        }
    }
}
