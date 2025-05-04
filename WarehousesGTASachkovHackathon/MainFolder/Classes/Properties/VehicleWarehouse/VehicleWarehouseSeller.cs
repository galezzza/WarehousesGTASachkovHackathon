using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Warehouses;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.VehicleWarehouse
{
    class VehicleWarehouseSeller
    {
        private readonly IReadOnlyList<string> _catalog;

        public VehicleWarehouseSeller()
        {
            _catalog = WarehouseFactory.GetAvailableWarehouseNames();
        }

        public IReadOnlyList<string> GetCatalog() => _catalog;

        public void Buy(string name, Player buyer)
        {
            if (!_catalog.Contains(name))
                throw new InvalidOperationException("Vehicle Warehouse is not available for sale.");

            var vehicleWarehouse = VehicleWarehouseFactory.CreateByName(name);
            buyer.BuyNewProperty(vehicleWarehouse);
        }
    }
}
