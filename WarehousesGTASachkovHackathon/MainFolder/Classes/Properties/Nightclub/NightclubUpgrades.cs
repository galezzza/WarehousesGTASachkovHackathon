using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Nightclub
{
    public class NightclubUpgrades : ProductionUpgrades
    {
        public NightclubUpgrades()
            : base()
        {
        }
        public NightclubUpgrades(bool isEquipmentUpgraded, bool isStaffUpgraded, bool isSecurityUpgraded)
            : base(isEquipmentUpgraded, isStaffUpgraded, isSecurityUpgraded)
        {
        }

        public override void InitializeValues()
        {
            EquipmentUpgradePrice = 1425000;
            StaffUpgradePrice = 475000;
            SecurityUpgradePrice = 695000;
            ReduceSingleUnitProductionTime = TimeSpan.FromSeconds(1.5);
        }
    }
}
