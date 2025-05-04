namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Warehouses
{
    public static class SellingVehicleWarehouseCargoSite
    { 
        static public int CalculateMoneyFromSale(int numberOfCargo)
        {
            int pricePerCargo;
            switch (numberOfCargo)
            {
                case 1:
                    pricePerCargo = 10000;
                    break;
                case 2:
                    pricePerCargo = 11000;
                    break;
                case 3:
                    pricePerCargo = 12000;
                    break;
                case <6:
                    pricePerCargo = 13000;
                    break;
                case < 8:
                    pricePerCargo = 13500;
                    break;
                case < 10:
                    pricePerCargo = 14000;
                    break;
                case < 15:
                    pricePerCargo = 14500;
                    break;
                case < 20:
                    pricePerCargo = 15000;
                    break;
                case < 25:
                    pricePerCargo = 15500;
                    break;
                case < 30:
                    pricePerCargo = 16000;
                    break;
                case < 35:
                    pricePerCargo = 16500;
                    break;
                case < 40:
                    pricePerCargo = 17000;
                    break;
                case < 45:
                    pricePerCargo = 17500;
                    break;
                case < 50:
                    pricePerCargo = 17500;
                    break;
                case < 60:
                    pricePerCargo = 18000;
                    break;
                case < 70:
                    pricePerCargo = 18250;
                    break;
                case < 80:
                    pricePerCargo = 18500;
                    break;
                case < 90:
                    pricePerCargo = 18750;
                    break;
                case < 100:
                    pricePerCargo = 19000;
                    break;
                case < 111:
                    pricePerCargo = 19500;
                    break;
                case 111:
                    pricePerCargo = 20000;
                    break;
                case > 111:
                    throw new InvalidOperationException("Invalid number of cargo.");
                    break;
                default:
                    return 0;
                    break;
            }
            return pricePerCargo * numberOfCargo;
        }
    }
}