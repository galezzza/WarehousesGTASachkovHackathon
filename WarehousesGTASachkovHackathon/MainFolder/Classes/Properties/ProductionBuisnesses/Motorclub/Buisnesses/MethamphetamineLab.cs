using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Motorclub.Buisnesses;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub.Buisnesses
{
    class MethamphetamineLab : MCProductionBuisness
    {
        public MethamphetamineLab(string name, int price) 
            : base(name, price, MCBuisnessType.DocumentForgeryOffice)
        {
        }

        public override IOwnedProperty AddOwner(Player player)
        {
            return new OwnedMethamphetamineLab(this, player);
        }
    }
}
