using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses
{
    abstract public class ProductionUpgrades 
    {
        public bool IsEquipmentUpgraded { get; private set; }
        public bool IsStaffUpgraded { get; private set; }
        public bool IsSecurityUpgraded { get; private set; }
        public int EquipmentUpgradePrice { get; protected set; }
        public int StaffUpgradePrice { get; protected set; }
        public int SecurityUpgradePrice { get; protected set; }
        public TimeSpan ReduceSingleUnitProductionTime { get; protected set; }

        public ProductionUpgrades(bool isEquipmentUpgraded, bool isStaffUpgraded, bool isSecurityUpgraded)
        {
            IsEquipmentUpgraded = isEquipmentUpgraded;
            IsStaffUpgraded = isStaffUpgraded;
            IsSecurityUpgraded = isSecurityUpgraded;
            InitializeValues();
        }

        public ProductionUpgrades()
        {
            IsEquipmentUpgraded = false;
            IsStaffUpgraded = false;
            IsSecurityUpgraded = false;
            InitializeValues();
        }

        abstract public void InitializeValues();

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
