using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Motorclub.Buisnesses.CashFactory;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Motorclub.Buisnesses
{
    class OwnedMethamphetamineLab : OwnedMCProductionBuisness
    {
        private Player player;

        public OwnedMethamphetamineLab(MethamphetamineLab methamphetamineLab, Player owner) 
            : base(methamphetamineLab, owner)
        {
        }

        public OwnedMethamphetamineLab(string name, int price, Player owner)
            : base(name, price, MCBuisnessesType.MethamphetamineLab, owner)
        {
        }

        public OwnedMethamphetamineLab(string name, int price, Player owner, ProductionUpgrades upgrades) 
            : base(name, price, owner, upgrades)
        {
        }
    }
}