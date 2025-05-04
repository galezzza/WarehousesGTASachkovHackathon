using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Bunker
{
    static class SellingBunkerStockSite
    {
        private static int BUNKER_BASE_SELLING_PRICE_PER_UNIT = 7500;
        private static int BUNKER_SUMMAND_SELLING_PRICE_FOR_PRODUCT = 1500;
        public static int CalculateMoneyFromSale(double NofProduct, SellDistance sellDistance, ProductionUpgrades upgrades)
        {
            int numberOfUpgrades = GetNumberOfUpgrades(upgrades);
            double distanceMultiplier = GetDistanceMultiplier(sellDistance);

            double pricePerUnit = (BUNKER_BASE_SELLING_PRICE_PER_UNIT +
                                    BUNKER_SUMMAND_SELLING_PRICE_FOR_PRODUCT * numberOfUpgrades
                                    ) * distanceMultiplier;
            return (int)pricePerUnit;
        }

        private static int GetNumberOfUpgrades(ProductionUpgrades upgrades)
        {
            int numberOfUpgrades = 0;
            if (upgrades.IsEquipmentUpgraded)
                numberOfUpgrades++;
            if (upgrades.IsStaffUpgraded)
                numberOfUpgrades++;
            return numberOfUpgrades;
        }

        private static double GetDistanceMultiplier(SellDistance sellDistance)
        {
            double distanceMultiplier = 1;
            if (sellDistance == SellDistance.Far)
            {
                distanceMultiplier = 1.5;
            }
            return distanceMultiplier;
        }
    }
}
