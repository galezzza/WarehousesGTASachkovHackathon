using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Bunker;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Warehouses;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Nightclub
{
    class NightclubSeller
    {
        private readonly IReadOnlyList<string> _catalog;

        public NightclubSeller()
        {
            _catalog = NightclubFactory.GetAvailableWarehouseNames();
        }

        public IReadOnlyList<string> GetCatalog() => _catalog;

        public void Buy(string name, Player buyer)
        {
            if (!_catalog.Contains(name))
                throw new InvalidOperationException("Bunker is not available for sale.");

            Nightclub nightclub = NightclubFactory.CreateByName(name);
            buyer.BuyNewProperty(nightclub);
        }
    }
}
