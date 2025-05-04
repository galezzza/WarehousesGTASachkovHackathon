using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Hangar
{
    class SellingHangarStockSite
    {
        public static int BASE_PRICE = 10000;

        private static HangarSaleBonus FIRST_BONUS = new HangarSaleBonus(35, 25);
        private static HangarSaleBonus SECOND_BONUS = new HangarSaleBonus(12, 10);
        private static HangarSaleBonus THIRD_BONUS = new HangarSaleBonus(5, 5);
        
        public static int CalculateMoneyFromSaleWithBonus(int amountOfCargo, HangarSaleBonus bonus)
        {
            int numberOfBonuses = amountOfCargo / bonus.Threshold;
            int bonusMoney = amountOfCargo * (bonus.Multiplier * numberOfBonuses / 100);
            
            return BASE_PRICE + bonusMoney;
        }

        public static int CalculateMoneyFromSaleByType(int amountOfCargo, BunkerCargo type)
        {
            int bonusTypeInt = (int)type/3;
            HangarSaleBonus bonus = bonusTypeInt switch
            {
                0 => FIRST_BONUS,
                1 => SECOND_BONUS,
                2 => THIRD_BONUS,
                _ => throw new ArgumentOutOfRangeException(nameof(type), "Invalid cargo type.")
            };
            int money = CalculateMoneyFromSaleWithBonus(amountOfCargo, bonus);
            return money;
        }

        public static int CalculateMoneyFromAllCargoSale(HangarWarehouse bunkerWarehouse)
        {
            int[] allCargoTypes = bunkerWarehouse.GetWarehouseAllCargosAsIntArray();
            int moneySum = 0;

            foreach (BunkerCargo cargo in Enum.GetValues(typeof(BunkerCargo)))
            {
                int amountOfCargo = allCargoTypes[(int)cargo];
                if (amountOfCargo > 0)
                {
                    moneySum += CalculateMoneyFromSaleByType(amountOfCargo, cargo);
                }
            }
            return moneySum;
        }
    }

    class HangarSaleBonus
    {
        public int Multiplier { get; }
        public int Threshold { get; }

        public HangarSaleBonus(int multiplier, int threshold)
        {
            Multiplier = multiplier;
            Threshold = threshold;
        }
    }
}
