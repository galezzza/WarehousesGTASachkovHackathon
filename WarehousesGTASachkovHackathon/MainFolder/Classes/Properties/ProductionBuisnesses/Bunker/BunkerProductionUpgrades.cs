using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Bunker
{
    public class BunkerProductionUpgrades : ProductionUpgrades
    {
        public BunkerProductionUpgrades()
            : base()
        {
        }
        public BunkerProductionUpgrades(bool isEquipmentUpgraded, bool isStaffUpgraded, bool isSecurityUpgraded)
            : base(isEquipmentUpgraded, isStaffUpgraded, isSecurityUpgraded)
        {
        }

        public override void InitializeValues()
        {
            EquipmentUpgradePrice = 1155000;
            StaffUpgradePrice = 598500;
            SecurityUpgradePrice = 351000;
            ReduceSingleUnitProductionTime = TimeSpan.FromSeconds(1.5);
        }
    }
}