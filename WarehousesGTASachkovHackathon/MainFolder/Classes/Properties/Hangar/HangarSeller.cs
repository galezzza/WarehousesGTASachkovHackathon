using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Bunker;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Warehouses;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Hangar
{
    class HangarSeller
    {
        private readonly IReadOnlyList<string> _catalog;

        public HangarSeller()
        {
            _catalog = WarehouseFactory.GetAvailableWarehouseNames();
        }

        public IReadOnlyList<string> GetCatalog() => _catalog;

        public void Buy(string name, Player buyer)
        {
            if (!_catalog.Contains(name))
                throw new InvalidOperationException("Hangar is not available for sale.");

            Hangar hangar = HangarFactory.CreateByName(name);
            buyer.BuyNewProperty(hangar);
        }
    }
}
