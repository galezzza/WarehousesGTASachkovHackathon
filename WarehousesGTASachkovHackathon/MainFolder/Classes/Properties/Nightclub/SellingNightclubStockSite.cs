using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Nightclub.Productions;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Nightclub
{
    public static class SellingNightclubStockSite
    {
        public static int[] SellingPricePerCrate = new int[]
        { 10000, 5000, 27000, 11475, 2025, 1350, 4750};

        public static int GetSellingPricePerCrateByType(NCProductionBuisnessType type)
        {
            return SellingPricePerCrate[(int)type];
        }

        public static int CalculateMoneyByType(int amount, NCProductionBuisnessType type)
        {
            int money = amount * GetSellingPricePerCrateByType(type);
            return money - money / 10;
        }

        public static int CalulateMoneyFromSellingAllTypes(int[] soldedCarets)
        {
            int totalMoney = 0;
            for (int i = 0; i < soldedCarets.Length; i++)
            {
                totalMoney += CalculateMoneyByType(soldedCarets[i], (NCProductionBuisnessType)i);
            }
            return soldedCarets.Sum() - soldedCarets.Sum()/10;
        }

    }
}
