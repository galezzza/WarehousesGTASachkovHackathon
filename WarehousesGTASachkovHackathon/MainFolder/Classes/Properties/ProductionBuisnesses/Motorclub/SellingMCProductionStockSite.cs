using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub
{
    static class SellingMCProductionStockSite
    {
        public static int[] BaseSellingPricePerUnit = new int[] { 1350, 2025, 4725, 11475, 27000 };
        public static int[] SummandSellingPriceForProduct = new int[] { 200, 300, 700, 1700, 4000 };
        public static int CalculateMoneyFromSale(MCBuisnessType buisnessType, double NofProduct, SellDistance sellDistance, MCProductionUpgrades upgrades)
        {
            ProductType productType = ConvertBuisnessTypeToProductType(buisnessType);
            int baseSellingPricePerUnit = GetBaseSellingPricePerUnit(productType);
            int summandSellingPriceForProduct = GetSummandSellingPriceForProduct(productType);
            int numberOfUpgrades = GetNumberOfUpgrades(upgrades);
            double distanceMultiplier = GetDistanceMultiplier(sellDistance);

            double pricePerUnit = (baseSellingPricePerUnit +
                                    summandSellingPriceForProduct * numberOfUpgrades
                                    ) * distanceMultiplier;
            return (int)pricePerUnit;
        }

        private static int GetBaseSellingPricePerUnit(ProductType productType)
        {
            return BaseSellingPricePerUnit[(int)productType];
        }

        private static int GetSummandSellingPriceForProduct(ProductType productType)
        {
            return SummandSellingPriceForProduct[(int)productType];
        }

        private static int GetNumberOfUpgrades(MCProductionUpgrades upgrades)
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

        private static ProductType ConvertBuisnessTypeToProductType(MCBuisnessType type)
        {
            switch (type)
            {
                case MCBuisnessType.CounterfeitCashFactory:
                    return ProductType.Cash;
                case MCBuisnessType.DocumentForgeryOffice:
                    return ProductType.Documents;
                case MCBuisnessType.WeedFarm:
                    return ProductType.Weed;
                case MCBuisnessType.MethamphetamineLab:
                    return ProductType.Methamphetamine;
                case MCBuisnessType.CocaineLockup:
                    return ProductType.Cocaine;
                default:
                    throw new ArgumentException("Unknown business type.", nameof(Type));
            }
        }
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
