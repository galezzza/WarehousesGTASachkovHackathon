using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Nightclub.Productions.Buisnesses
{
    public class CargoAndShipmentsForNC : NCProductionBuisness
    {
        public CargoAndShipmentsForNC(int numberOfFloors, NightclubUpgrades upgrades) 
            : base(NCProductionBuisnessType.CargoAndShipments, numberOfFloors, upgrades)
        {
        }
    }
}
