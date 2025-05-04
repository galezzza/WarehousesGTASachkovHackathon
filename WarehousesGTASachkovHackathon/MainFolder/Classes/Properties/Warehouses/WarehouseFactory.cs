using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Warehouses
{
    public static class WarehouseFactory
    {
        public static Warehouse CreateByName(string name)
        {
            return name switch
            {
                "Small Warehouse" => new Warehouse("Small Warehouse", WarehouseType.Small, 1),
                "Medium Warehouse" => new Warehouse("Medium Warehouse", WarehouseType.Medium,1),
                "Large Warehouse" => new Warehouse("Large Warehouse", WarehouseType.Large, 1),
                _ => throw new ArgumentException("Unknown warehouse name.", nameof(name))
            };
        }

        public static IReadOnlyList<string> GetAvailableWarehouseNames()
        => new List<string> { "Small Warehouse", "Medium Warehouse", "Large Warehouse" };
    }

}
