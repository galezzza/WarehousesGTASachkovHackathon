using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub.Buisnesses
{
    class OwnedCocaineLockup : OwnedMCProductionBuisness
    {
        private Player player;

        public OwnedCocaineLockup(CocaineLockup cocaineBuisness, Player owner) 
            : base(cocaineBuisness, owner)
        {
        }

        public OwnedCocaineLockup(string name, int price, Player owner)
            : base(name, price, MCBuisnessType.CocaineLockup, owner)
        {
        }

        public OwnedCocaineLockup(string name, int price, Player owner, MCProductionUpgrades upgrades) 
            : base(name, price, owner, upgrades)
        {
        }
    }
}