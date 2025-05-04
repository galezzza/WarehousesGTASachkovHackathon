using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Motorclub.Buisnesses.CashFactory;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Motorclub.Buisnesses
{
    class OwnedCocaineLockup : OwnedMCProductionBuisness
    {
        private Player player;

        public OwnedCocaineLockup(CocaineLockup cocaineBuisness, Player owner) 
            : base(cocaineBuisness, owner)
        {
        }

        public OwnedCocaineLockup(string name, int price, Player owner)
            : base(name, price, MCBuisnessesType.CocaineLockup, owner)
        {
        }

        public OwnedCocaineLockup(string name, int price, Player owner, ProductionUpgrades upgrades) 
            : base(name, price, owner, upgrades)
        {
        }
    }
}