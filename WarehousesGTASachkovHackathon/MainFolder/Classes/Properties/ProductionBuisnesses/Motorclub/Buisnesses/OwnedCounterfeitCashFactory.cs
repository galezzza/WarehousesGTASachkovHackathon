using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub.Buisnesses
{
    class OwnedCounterfeitCashFactory : OwnedMCProductionBuisness
    {
        private Player player;

        public OwnedCounterfeitCashFactory(CounterfeitCashFactory counterfeitCashFactory, Player owner) 
            : base(counterfeitCashFactory, owner)
        {
        }

        public OwnedCounterfeitCashFactory(string name, int price, Player owner)
            : base(name, price, MCBuisnessType.CounterfeitCashFactory, owner)
        {
        }

        public OwnedCounterfeitCashFactory(string name, int price, Player owner, MCProductionUpgrades upgrades) 
            : base(name, price, owner, upgrades)
        {
        }
    }
}