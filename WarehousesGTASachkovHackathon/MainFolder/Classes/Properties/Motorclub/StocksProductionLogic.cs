namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Motorclub
{
    public class StocksProductionLogic
    {
        public double SuppliesPercentage { get; private set; } = 0;
        public double Product { get; private set; } = 0;
        public double ProductCapacity { get; private set; }
        public double Ratio { get; private set; }
        public TimeSpan TimeToProduce { get; private set; }

        public StocksProductionLogic(double ratio, double capacity, TimeSpan timeToProduce)
        {
            Ratio = ratio;
            ProductCapacity = capacity;
            TimeToProduce = timeToProduce;
        }

        public void ReduceTimeToProduce(TimeSpan timeToProduce)
        {
            if (timeToProduce < TimeSpan.Zero)
                throw new ArgumentException("Time to produce cannot be negative.");
            TimeToProduce -= timeToProduce;
        }

        public int CalculateSuppliesToBuy()
        {
            int multplier = (int)((100 - SuppliesPercentage) / 20);
            return 15000 * multplier;
        }
        public void SuppliesToMax()
        {
            if (SuppliesPercentage > 100)
                throw new ArgumentException("Supplies percentage cannot be higher than 100.");
            SuppliesPercentage = 100;
        }
        public void ProductToMin()
        {
            if (SuppliesPercentage <= 0)
                throw new ArgumentException("There are no products.");
            Product = 0;
        }

        public void Produce()
        {
            double howMuchProductMayBeProduced = ProductCapacity - Product;
            double howMuchProductCanBeProduced = SuppliesPercentage / 100 * Ratio / 100 * ProductCapacity;

            if (howMuchProductCanBeProduced > howMuchProductMayBeProduced)
            { 
                Product = ProductCapacity;
                SuppliesPercentage -= howMuchProductMayBeProduced * 100 * 100 / (ProductCapacity * Ratio);
            }
            else
            {
                SuppliesPercentage = 0;
                Product += howMuchProductCanBeProduced;
            }
        }
    }
}