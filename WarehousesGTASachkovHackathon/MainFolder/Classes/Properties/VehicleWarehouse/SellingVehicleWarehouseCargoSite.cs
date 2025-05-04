using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.VehicleWarehouse.Car;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.VehicleWarehouse
{
    public static class SellingVehicleWarehouseCargoSite
    { 
        static private int[][] PricesFromSelling =
        {
            //          Private ||  Showroom    ||  Specialist Dealer
            new int[] { 40000,      70000,          100000 },            // TOP
            new int[] { 25000,      43750,          62500 },            // MID
            new int[] { 15000,      26250,          37500 }             // LOW
        };
        static private int[][] CommisionFromSelling =
        {
            //          Private ||  Showroom    ||  Specialist Dealer
            new int[] { 0,          10000,          20000 },            // TOP
            new int[] { 0,          6250,           12500 },            // MID
            new int[] { 0,          3750,           7500 }             // LOW
        };

        static public int CalculateMoneyFromSale(CargoCarType cargoCarType, CargoCarBuyerType cargoCarBuyerType)
        {
            return PricesFromSelling[(int)cargoCarType][(int)cargoCarBuyerType] 
                - CommisionFromSelling[(int)cargoCarType][(int)cargoCarBuyerType];
        }
    }

    public enum CargoCarBuyerType
    {
        Private,
        Showroom,
        SpecialistDealer
    }
}