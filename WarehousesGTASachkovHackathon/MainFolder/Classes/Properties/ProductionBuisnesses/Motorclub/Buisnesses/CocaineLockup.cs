using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub.Buisnesses
{
    class CocaineLockup : MCProductionBuisness
    {
        public CocaineLockup(string name, int price) 
            : base(name, price, MCBuisnessType.CocaineLockup)
        {
        }

        public override IOwnedProperty AddOwner(Player player)
        {
            return new OwnedCocaineLockup(this, player);
        }
    }
}
