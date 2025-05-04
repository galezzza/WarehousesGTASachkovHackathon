using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.VehicleWarehouse;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub
{
    public abstract class MCProductionBuisness : ProductionBuisness
    {
        public string Name { get; }
        public int Price { get; }
        public MCBuisnessType Type { get; private set; }

        protected MCProductionBuisness(string name, int price, MCBuisnessType type)
            : base(name, price)
        {
        }
    }
}
