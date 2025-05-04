using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.VehicleWarehouse;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Motorclub
{
    public abstract class MCProductionBuisness : IProperty
    {
        public string Name { get; }
        public int Price { get; }
        public MCBuisnessesType Type { get; private set; }

        protected MCProductionBuisness(string name, int price, MCBuisnessesType type)
        {
            Name = name;
            Price = price;
            Type = type;
        }

        public abstract IOwnedProperty AddOwner(Player player);
    }
}
