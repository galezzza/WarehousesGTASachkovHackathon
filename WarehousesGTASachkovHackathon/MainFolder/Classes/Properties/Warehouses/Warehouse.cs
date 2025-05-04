using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Warehouses
{
    public class Warehouse : IProperty
    {
        public string Name { get; }
        public int Price { get; }
        public WarehouseType Type { get; }
        protected int CapacityOfCargo => Type switch
        {
            WarehouseType.Small => 16,
            WarehouseType.Medium => 42,
            WarehouseType.Large => 111,
            _ => throw new InvalidOperationException("Unknown warehouse type.")
        };

        public Warehouse(string name, WarehouseType type, int price)
        {
            Name = name;
            Type = type;
            Price = price;
        }

        public IOwnedProperty AddOwner(Player player)
        {
            return new OwnedWarehouse(this, player);
        }



        public int GetCapacityOfCargo() => CapacityOfCargo;
    }

}
