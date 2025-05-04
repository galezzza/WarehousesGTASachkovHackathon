namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Nightclub.Productions
{
    abstract public class NCProductionBuisness
    {
        public int Capacity { get; private set; }
        public int CurrentLoad { get; private set; } = 0;
        public TimeSpan ProductionTimePerCrate { get; private set; }
        public bool IsAvailable { get; private set; } = false;

        public NCProductionBuisness(NCProductionBuisnessType type, int numberOfFloors, NightclubUpgrades upgrade)
        {
            Capacity = NCProductionBuisnessFactory.GetCapacityFromNCTypeAndNofFloors(type, numberOfFloors);
            ProductionTimePerCrate = NCProductionBuisnessFactory
                .GetProductionTimePerCrateFromNCTypeAndUpgrades(type, upgrade.IsEquipmentUpgraded);
            CurrentLoad = 0;
            IsAvailable = false;
        }

        public void SetAvailable(bool isAvailable)
        {
            IsAvailable = isAvailable;
        }

        public void AttachUpgrade(NightclubUpgrades upgrade)
        {
            ProductionTimePerCrate = NCProductionBuisnessFactory
                .GetProductionTimePerCrateFromNCTypeAndUpgrades(NCProductionBuisnessType.CargoAndShipments, upgrade.IsEquipmentUpgraded);
        }

        public void UpdateNumberOfFloors(int numberOfFloors, NCProductionBuisnessType type)
        {
            if (numberOfFloors < 1)
            {
                throw new ArgumentException("Number of floors must be at least 1.");
            }
            else if (NCProductionBuisnessFactory.GetCapacityFromNCTypeAndNofFloors(type, numberOfFloors) <= Capacity)
            {
                throw new ArgumentException("Number of floors can only be increased");
            }
            else if (numberOfFloors > 5)
            {
                throw new ArgumentException("Number of floors cannot be more than 5.");
            }
            else
            {
                Capacity = NCProductionBuisnessFactory.GetCapacityFromNCTypeAndNofFloors(type, numberOfFloors);
            }
        }

        public void ProduceCrate()
        {
            CurrentLoad = Capacity;
        }

        public void StopProducing()
        {

        }

        public void ReduceSomeProduct(int amount)
        {
            if (CurrentLoad < amount)
                throw new ArgumentException("Not enough product to sell.");
            else
            {
                CurrentLoad -= amount;
            }
        }

        public void ProductToMin()
        {
            if (CurrentLoad <= 0)
                throw new ArgumentException("There are no products.");
            else
            {
                CurrentLoad = 0;
            }
        }
    }
}