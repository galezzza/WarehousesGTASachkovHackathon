using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Bunker;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Hangar
{
    public class Hangar : IProperty
    {
        public string Name { get; }
        public int Price { get; }

        public Hangar(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public IOwnedProperty AddOwner(Player player)
        {
            return new OwnedHangar(this, player);
        }
    }
}
