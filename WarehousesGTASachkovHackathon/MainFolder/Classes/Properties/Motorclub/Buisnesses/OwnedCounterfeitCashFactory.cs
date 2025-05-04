using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Motorclub.Buisnesses.CashFactory;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Motorclub.Buisnesses
{
    class OwnedCounterfeitCashFactory : OwnedMCProductionBuisness
    {
        private Player player;

        public OwnedCounterfeitCashFactory(CounterfeitCashFactory counterfeitCashFactory, Player owner) 
            : base(counterfeitCashFactory, owner)
        {
        }

        public OwnedCounterfeitCashFactory(string name, int price, Player owner)
            : base(name, price, MCBuisnessesType.CounterfeitCashFactory, owner)
        {
        }

        public OwnedCounterfeitCashFactory(string name, int price, Player owner, ProductionUpgrades upgrades) 
            : base(name, price, owner, upgrades)
        {
        }
    }
}