using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Warehouses
{
    class WarehouseSeller
    {
        private readonly IReadOnlyList<string> _catalog;

        public WarehouseSeller()
        {
            _catalog = WarehouseFactory.GetAvailableWarehouseNames();
        }

        public IReadOnlyList<string> GetCatalog() => _catalog;

        public void Buy(string name, Player buyer)
        {
            if (!_catalog.Contains(name))
                throw new InvalidOperationException("Warehouse is not available for sale.");

            Warehouse warehouse = WarehouseFactory.CreateByName(name);
            buyer.BuyNewProperty(warehouse);
        }
        public void Buy(Player buyer, WarehouseType type)
        {
            var warehouse = WarehouseFactory.CreateRandomByType(type);
            buyer.BuyNewProperty(warehouse);
        }
    }
}
