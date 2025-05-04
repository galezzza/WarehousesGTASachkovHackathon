using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub.Buisnesses
{
    class OwnedWeedFarm : OwnedMCProductionBuisness
    {
        private Player player;

        public OwnedWeedFarm(WeedFarm weedFarm, Player owner) 
            : base(weedFarm, owner)
        {
        }

        public OwnedWeedFarm(string name, int price, Player owner)
            : base(name, price, MCBuisnessType.WeedFarm, owner)
        {
        }

        public OwnedWeedFarm(string name, int price, Player owner, MCProductionUpgrades upgrades) 
            : base(name, price, owner, upgrades)
        {
        }
    }
}