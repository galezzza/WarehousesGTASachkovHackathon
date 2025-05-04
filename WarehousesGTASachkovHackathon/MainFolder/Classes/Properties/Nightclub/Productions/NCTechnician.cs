namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Nightclub.Productions
{
    public class NCTechnician
    {
        public string Name { get; private set; }
        public int Price { get; private set; }
        public bool IsBought { get; private set; } = false;
        public NCProductionBuisness? AllocatedBuisness { get; private set; }

        public NCTechnician(string name, int price)
        {
            Name = name;
            Price = price;
            AllocatedBuisness = null;
            IsBought = false;
        }

        public void BuyTechnician()
        {
            if (IsBought)
            {
                throw new InvalidOperationException("This technician is already bought.");
            }
            IsBought = true;
        }

        public bool IsAvailable()
        {
            return AllocatedBuisness == null;
        }
        public void AllocateBuisness(NCProductionBuisness buisness)
        {
            if (AllocatedBuisness != null)
            {
                throw new InvalidOperationException("This technician is already allocated to a business.");
            }
            AllocatedBuisness = buisness;
            buisness.SetAvailable(false);
            buisness.ProduceCrate();
        }

        public void FreeTechnician()
        {
            if (AllocatedBuisness == null)
            {
                throw new InvalidOperationException("This technician is not allocated to any business.");
            }
            AllocatedBuisness.SetAvailable(true);
            AllocatedBuisness.StopProducing();
            AllocatedBuisness = null;
        }
    }
}