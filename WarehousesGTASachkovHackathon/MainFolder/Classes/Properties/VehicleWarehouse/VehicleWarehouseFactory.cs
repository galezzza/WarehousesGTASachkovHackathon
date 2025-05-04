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
                "CypressFlatsVehicleWarehouse" => new VehicleWarehouse("Cypress Flats Vehicle Warehouse", 2675000),
                "DavisVehicleWarehouse" => new VehicleWarehouse("Davis Vehicle Warehouse", 2495000),
                "ElBurroHeightsVehicleWarehouse" => new VehicleWarehouse("ElBurro Heights Vehicle Warehouse", 1635000),
                "ElysianIslandVehicleWarehouse" => new VehicleWarehouse("Elysian Island Vehicle Warehouse", 1950000),
                "LaMesaVehicleWarehouse" => new VehicleWarehouse("La Mesa Vehicle Warehouse", 1500000),
                "LaPuertaVehicleWarehouse" => new VehicleWarehouse("La Puerta Vehicle Warehouse", 2735000),
                "LSIAVehicleWarehouse" => new VehicleWarehouse("LSIA Vehicle Warehouse", 2170000),
                "LSIAVehicleWarehouse2" => new VehicleWarehouse("LSIA Vehicle Warehouse 2", 2300000),
                "MurrietaHeightsVehicleWarehouse" => new VehicleWarehouse("Murrieta Heights VehicleWarehouse", 2850000),
                _ => throw new ArgumentException("Unknown warehouse name.", nameof(name))
            };
        }

        public static IReadOnlyList<string> GetAvailableWarehouseNames()
        => new List<string>
        {
            "CypressFlatsVehicleWarehouse",
            "DavisVehicleWarehouse",
            "ElBurroHeightsVehicleWarehouse",
            "ElysianIslandVehicleWarehouse",
            "LaMesaVehicleWarehouse",
            "LaPuertaVehicleWarehouse",
            "LSIAVehicleWarehouse",
            "LSIAVehicleWarehouse2",
            "MurrietaHeightsVehicleWarehouse"
        };
    }
}
