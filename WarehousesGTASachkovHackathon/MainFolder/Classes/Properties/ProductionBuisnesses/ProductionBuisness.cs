using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses
{
    public abstract class ProductionBuisness : IProperty
    {
        public string Name { get; }
        public int Price { get; }

        protected ProductionBuisness(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public abstract IOwnedProperty AddOwner(Player player);
    }
}
