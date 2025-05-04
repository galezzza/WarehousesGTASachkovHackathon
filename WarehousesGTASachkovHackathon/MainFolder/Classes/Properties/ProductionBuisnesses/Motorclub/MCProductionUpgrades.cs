namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub
{
    public class MCProductionUpgrades : ProductionUpgrades
    {
        public MCBuisnessType Type { get; private set; }

        public MCProductionUpgrades(MCBuisnessType type) 
            : base(false, false, false)
        {
            Type = type;
        }

        public MCProductionUpgrades(bool isEquipmentUpgraded, bool isStaffUpgraded, bool isSecurityUpgraded, MCBuisnessType type)
            : base(isEquipmentUpgraded, isStaffUpgraded, isSecurityUpgraded)
        {
            Type = type;
        }


        public override void InitializeValues()
        {
            switch (Type)
            {
                case MCBuisnessType.CounterfeitCashFactory:
                    EquipmentUpgradePrice = 880000;
                    StaffUpgradePrice = 273000;
                    SecurityUpgradePrice = 456000;
                    ReduceSingleUnitProductionTime = TimeSpan.FromSeconds(2);
                    break;
                case MCBuisnessType.DocumentForgeryOffice:
                    EquipmentUpgradePrice = 550000;
                    StaffUpgradePrice = 195000;
                    SecurityUpgradePrice = 285000;
                    ReduceSingleUnitProductionTime = TimeSpan.FromSeconds(1);
                    break;
                case MCBuisnessType.WeedFarm:
                    EquipmentUpgradePrice = 990000;
                    StaffUpgradePrice = 273000;
                    SecurityUpgradePrice = 313000;
                    ReduceSingleUnitProductionTime = TimeSpan.FromSeconds(1);
                    break;
                case MCBuisnessType.MethamphetamineLab:
                    EquipmentUpgradePrice = 1100000;
                    StaffUpgradePrice = 331500;
                    SecurityUpgradePrice = 513000;
                    ReduceSingleUnitProductionTime = TimeSpan.FromSeconds(6);
                    break;
                case MCBuisnessType.CocaineLockup:
                    EquipmentUpgradePrice = 935000;
                    StaffUpgradePrice = 390000;
                    SecurityUpgradePrice = 570000;
                    ReduceSingleUnitProductionTime = TimeSpan.FromSeconds(10);
                    break;

                default:
                    throw new ArgumentException("Unknown business type.");
            }
        }
    }
}