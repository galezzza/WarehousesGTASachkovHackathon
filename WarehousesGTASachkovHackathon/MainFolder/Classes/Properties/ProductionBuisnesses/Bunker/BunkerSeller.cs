using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.VehicleWarehouse;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Warehouses;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Bunker
{
    class BunkerSeller
    {
        private readonly IReadOnlyList<string> _catalog;

        public BunkerSeller()
        {
            _catalog = WarehouseFactory.GetAvailableWarehouseNames();
        }

        public IReadOnlyList<string> GetCatalog() => _catalog;

        public void Buy(string name, Player buyer)
        {
            if (!_catalog.Contains(name))
                throw new InvalidOperationException("Bunker is not available for sale.");

            Bunker bunker = BunkerFactory.CreateByName(name);
            buyer.BuyNewProperty(bunker);
        }
    }

}
