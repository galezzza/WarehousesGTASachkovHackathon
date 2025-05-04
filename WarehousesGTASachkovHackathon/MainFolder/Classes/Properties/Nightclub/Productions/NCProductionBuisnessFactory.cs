using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Nightclub.Productions
{
    class NCProductionBuisnessFactory
    {
        public static int GetCapacityFromNCTypeAndNofFloors(NCProductionBuisnessType type, int numberOfFloors)
        {
            return type switch
            {
                NCProductionBuisnessType.CargoAndShipments => 10 * numberOfFloors,
                NCProductionBuisnessType.SportingGoods => 20 * numberOfFloors,
                NCProductionBuisnessType.SouthAmericanImports => 2 * numberOfFloors,
                NCProductionBuisnessType.PharmacauticalResearch => 4 * numberOfFloors,
                NCProductionBuisnessType.OrganicProduce => 16 * numberOfFloors,
                NCProductionBuisnessType.PrintingAndCopying => 12 * numberOfFloors,
                NCProductionBuisnessType.CashCreation => 8 * numberOfFloors,
                _ => throw new ArgumentException("Unknown buisness type.", nameof(type))
            };
        }
        public static TimeSpan GetProductionTimePerCrateFromNCTypeAndUpgrades
            (NCProductionBuisnessType type, bool isEquipmentUpgraded)
        {
            
            return type switch
            {
                NCProductionBuisnessType.CargoAndShipments => TimeSpan.FromMinutes(CalculateProductionSpeed(140, isEquipmentUpgraded)),
                NCProductionBuisnessType.SportingGoods => TimeSpan.FromMinutes(CalculateProductionSpeed(80, isEquipmentUpgraded)),
                NCProductionBuisnessType.SouthAmericanImports => TimeSpan.FromMinutes(CalculateProductionSpeed(240, isEquipmentUpgraded)),
                NCProductionBuisnessType.PharmacauticalResearch => TimeSpan.FromMinutes(CalculateProductionSpeed(120, isEquipmentUpgraded)),
                NCProductionBuisnessType.OrganicProduce => TimeSpan.FromMinutes(CalculateProductionSpeed(40, isEquipmentUpgraded)),
                NCProductionBuisnessType.PrintingAndCopying => TimeSpan.FromMinutes(CalculateProductionSpeed(30, isEquipmentUpgraded)),
                NCProductionBuisnessType.CashCreation => TimeSpan.FromMinutes(CalculateProductionSpeed(60, isEquipmentUpgraded)),
                _ => throw new ArgumentException("Unknown warehouse name.", nameof(type))
            };
        }
        public static int CalculateProductionSpeed(int timeRate, bool isEquipmentUpgraded)
        {
            if (isEquipmentUpgraded)
            {
                timeRate = timeRate / 2;
            }
            return timeRate;
        }
    }
}
