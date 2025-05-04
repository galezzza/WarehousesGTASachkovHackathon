using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Warehouses;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.VehicleWarehouse
{
    class VehicleWarehouseFactory
    {
        public static VehicleWarehouse CreateByName(string name)
        {
            return name switch
            {
                "Small Warehouse" => new VehicleWarehouse("Small Warehouse", 1),
                "Medium Warehouse" => new VehicleWarehouse("Medium Warehouse", 1),
                "Large Warehouse" => new VehicleWarehouse("Large Warehouse", 1),
                _ => throw new ArgumentException("Unknown warehouse name.", nameof(name))
            };
        }

        public static IReadOnlyList<string> GetAvailableWarehouseNames()
        => new List<string> { "Small Warehouse", "Medium Warehouse", "Large Warehouse" };
    }
}
