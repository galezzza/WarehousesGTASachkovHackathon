using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Motorclub.Buisnesses.CashFactory;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Motorclub.Buisnesses
{
    class OwnedWeedFarm : OwnedMCProductionBuisness
    {
        private Player player;

        public OwnedWeedFarm(WeedFarm weedFarm, Player owner) 
            : base(weedFarm, owner)
        {
        }

        public OwnedWeedFarm(string name, int price, Player owner)
            : base(name, price, MCBuisnessesType.WeedFarm, owner)
        {
        }

        public OwnedWeedFarm(string name, int price, Player owner, ProductionUpgrades upgrades) 
            : base(name, price, owner, upgrades)
        {
        }
    }
}