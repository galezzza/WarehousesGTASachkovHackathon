using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Motorclub.Buisnesses.CashFactory;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Motorclub
{
    static class SellingProductionStockSite
    {
        public static int[] BaseSellingPricePerUnit = new int[] { 1350, 2025, 4725, 11475, 27000 };
        public static int[] SummandSellingPriceForProduct = new int[] { 200, 300, 700, 1700, 4000 };
        public static double CalculateMoneyFromSale(ProductType productType, double NofProduct, SellDistance sellDistance, ProductionUpgrades upgrades)
        {
            int baseSellingPricePerUnit = GetBaseSellingPricePerUnit(productType);
            int summandSellingPriceForProduct = GetSummandSellingPriceForProduct(productType);
            int numberOfUpgrades = GetNumberOfUpgrades(upgrades);
            double distanceMultiplier = GetDistanceMultiplier(sellDistance);

            double pricePerUnit = (baseSellingPricePerUnit +
                                    summandSellingPriceForProduct * numberOfUpgrades
                                    ) * distanceMultiplier;
            return pricePerUnit;
        }

        private static int GetBaseSellingPricePerUnit(ProductType productType)
        {
            return BaseSellingPricePerUnit[(int)productType];
        }

        private static int GetSummandSellingPriceForProduct(ProductType productType)
        {
            return SummandSellingPriceForProduct[(int)productType];
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


    public enum SellDistance
    {
        Close = 1,
        Far = 2
    }

    public enum ProductType
    {
        Documents = 0,
        Weed = 1,
        Cash = 2,
        Methamphetamine = 3,
        Cocaine = 4,
    }
}
