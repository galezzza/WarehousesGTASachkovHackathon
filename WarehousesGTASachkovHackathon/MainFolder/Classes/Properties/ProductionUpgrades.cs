namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Motorclub.Buisnesses.CashFactory
{
    public class ProductionUpgrades
    {
        public bool IsEquipmentUpgraded { get; private set; }
        public bool IsStaffUpgraded { get; private set; }
        public bool IsSecurityUpgraded { get; private set; }
        public MCBuisnessesType Type { get; private set; }
        public int EquipmentUpgradePrice  { get; private set; }
        public int StaffUpgradePrice { get; private set; }
        public int SecurityUpgradePrice { get; private set; }
        public TimeSpan ReduceSingleUnitProductionTime { get; private set; }

        public ProductionUpgrades(bool isEquipmentUpgraded, bool isStaffUpgraded, bool isSecurityUpgraded, MCBuisnessesType type)
        {
            IsEquipmentUpgraded = isEquipmentUpgraded;
            IsStaffUpgraded = isStaffUpgraded;
            IsSecurityUpgraded = isSecurityUpgraded;
            Type = type;
            InitializePricesFromBuisnessType(type);
        }

        public ProductionUpgrades(MCBuisnessesType type)
        {
            IsEquipmentUpgraded = false;
            IsStaffUpgraded = false;
            IsSecurityUpgraded = false;
            Type = type;
            InitializePricesFromBuisnessType(type);
        }

        private void InitializePricesFromBuisnessType(MCBuisnessesType type)
        {
            switch (type)
            {
                case MCBuisnessesType.CounterfeitCashFactory:
                    EquipmentUpgradePrice = 880000;
                    StaffUpgradePrice = 273000;
                    SecurityUpgradePrice = 456000;
                    ReduceSingleUnitProductionTime = TimeSpan.FromSeconds(2);
                    break;
                case MCBuisnessesType.DocumentForgeryOffice:
                    EquipmentUpgradePrice = 550000;
                    StaffUpgradePrice = 195000;
                    SecurityUpgradePrice = 285000;
                    ReduceSingleUnitProductionTime = TimeSpan.FromSeconds(1);
                    break;
                case MCBuisnessesType.WeedFarm:
                    EquipmentUpgradePrice = 990000;
                    StaffUpgradePrice = 273000;
                    SecurityUpgradePrice = 313000;
                    ReduceSingleUnitProductionTime = TimeSpan.FromSeconds(1);
                    break;
                case MCBuisnessesType.MethamphetamineLab:
                    EquipmentUpgradePrice = 1100000;
                    StaffUpgradePrice = 331500;
                    SecurityUpgradePrice = 513000;
                    ReduceSingleUnitProductionTime = TimeSpan.FromSeconds(6);
                    break;
                case MCBuisnessesType.CocaineLockup:
                    EquipmentUpgradePrice = 935000;
                    StaffUpgradePrice = 390000;
                    SecurityUpgradePrice = 570000;
                    ReduceSingleUnitProductionTime = TimeSpan.FromSeconds(10);
                    break;

                default:
                    throw new ArgumentException("Unknown business type.", nameof(type));
            }
        }


        public void UpgradeEquipment()
        {
            if (IsEquipmentUpgraded)
                throw new InvalidOperationException("Equipment is already upgraded.");
            IsEquipmentUpgraded = true;
        }

        public void UpgradeStaff()
        {
            if (IsStaffUpgraded)
                throw new InvalidOperationException("Staff is already upgraded.");
            IsStaffUpgraded = true;
        }

        public void UpgradeSecurity()
        {
            if (IsSecurityUpgraded)
                throw new InvalidOperationException("Security is already upgraded.");
            IsSecurityUpgraded = true;
        }
    }
}