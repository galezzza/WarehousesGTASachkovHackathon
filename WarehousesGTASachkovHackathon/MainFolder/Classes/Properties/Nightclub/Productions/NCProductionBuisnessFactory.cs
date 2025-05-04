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
                NCProductionBuisnessType.CargoAndShipments => 5 * numberOfFloors,
                NCProductionBuisnessType.SportingGoods => 5 * numberOfFloors,
                NCProductionBuisnessType.SouthAmericanImports => 5 * numberOfFloors,
                NCProductionBuisnessType.PharmacauticalResearch => 5 * numberOfFloors,
                NCProductionBuisnessType.OrganicProduce => 5 * numberOfFloors,
                NCProductionBuisnessType.PrintingAndCopying => 5 * numberOfFloors,
                NCProductionBuisnessType.CashCreation => 5 * numberOfFloors,
                _ => throw new ArgumentException("Unknown buisness type.", nameof(type))
            };
        }
        public static TimeSpan GetProductionTimePerCrateFromNCTypeAndUpgrades
            (NCProductionBuisnessType type, bool isEquipmentUpgraded)
        {
            int timeRate = 5;
            if ( isEquipmentUpgraded)
            {
                timeRate = timeRate / 2;
            }
            return type switch
            {
                NCProductionBuisnessType.CargoAndShipments => TimeSpan.FromSeconds(timeRate),
                NCProductionBuisnessType.SportingGoods => TimeSpan.FromSeconds(timeRate),
                NCProductionBuisnessType.SouthAmericanImports => TimeSpan.FromSeconds(timeRate),
                NCProductionBuisnessType.PharmacauticalResearch => TimeSpan.FromSeconds(timeRate),
                NCProductionBuisnessType.OrganicProduce => TimeSpan.FromSeconds(timeRate),
                NCProductionBuisnessType.PrintingAndCopying => TimeSpan.FromSeconds(timeRate),
                NCProductionBuisnessType.CashCreation => TimeSpan.FromSeconds(timeRate),
                _ => throw new ArgumentException("Unknown warehouse name.", nameof(type))
            };
        }
    }
}
