using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.VehicleWarehouse;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub
{
    class MCBuisnessSeller
    {
        public void Buy(MCBuisnessType type, MCBuisnessLocations location, Player buyer)
        {
            var buisnessFactory = MCBuisnessFactory.CreateByTypeAndLocation(location, type);
            buyer.BuyNewProperty(buisnessFactory);
        }
    }
}
