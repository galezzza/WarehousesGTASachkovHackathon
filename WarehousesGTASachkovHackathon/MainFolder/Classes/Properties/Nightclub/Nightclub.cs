using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Hangar;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Nightclub
{
    public class Nightclub : IProperty
    {
        public string Name { get; }
        public int Price { get; }

        public Nightclub(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public IOwnedProperty AddOwner(Player player)
        {
            return new OwnedNightclub(this, player);
        }
    }
}
