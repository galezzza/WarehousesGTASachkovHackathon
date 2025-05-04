using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Warehouses;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.VehicleWarehouse
{
    public class VehicleWarehouse : IProperty
    {   
        public string Name { get; }
        public int Price { get; }
        protected int CapacityOfCargoCars { get; } = 40;

        public VehicleWarehouse(string name, int price)
        {
            Name = name;
            Price = price;
            CapacityOfCargoCars = 40;
        }

        public IOwnedProperty AddOwner(Player player)
        {
            return new OwnedVehicleWarehouse(this, player);
        }
    }
}
