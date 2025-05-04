using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub.Buisnesses
{
    class OwnedMethamphetamineLab : OwnedMCProductionBuisness
    {
        private Player player;

        public OwnedMethamphetamineLab(MethamphetamineLab methamphetamineLab, Player owner) 
            : base(methamphetamineLab, owner)
        {
        }

        public OwnedMethamphetamineLab(string name, int price, Player owner)
            : base(name, price, MCBuisnessType.MethamphetamineLab, owner)
        {
        }

        public OwnedMethamphetamineLab(string name, int price, Player owner, MCProductionUpgrades upgrades) 
            : base(name, price, owner, upgrades)
        {
        }
    }
}