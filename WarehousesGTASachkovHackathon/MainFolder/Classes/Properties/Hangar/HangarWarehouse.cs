namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Hangar
{
    public class HangarWarehouse
    {
        public static int MAX_CAPACITY = 50;
        private int[] warehouseAbstraction 
            = {0, 0, 0, 0, 0, 0, 0, 0 };
        public int CurrentLoad => warehouseAbstraction.Sum();

        public void AddCargo(BunkerCargo cargo, int amount)
        {
            if (amount < 0)
                throw new ArgumentException("Amount cannot be negative.");
            if (amount + warehouseAbstraction.Sum() > MAX_CAPACITY)
                throw new InvalidOperationException("Exceeds maximum capacity.");
            warehouseAbstraction[(int)cargo] += amount;
        }

        public void RemoveCargo(BunkerCargo cargo)
        {
            warehouseAbstraction[(int)cargo] = 0;
        }
        public void RemoveAllCargo()
        {
            for (int i = 0; i < warehouseAbstraction.Length; i++)
            {
                warehouseAbstraction[i] = 0;
            }
        }

        public int[] GetWarehouseAllCargosAsIntArray()
        {
            return warehouseAbstraction;
        }

        public int GetCargoAmountByType(BunkerCargo type)
        {
            return warehouseAbstraction[(int)type];
        }

        public HangarWarehouse()
        {
            for (int i = 0; i < warehouseAbstraction.Length; i++)
            {
                warehouseAbstraction[i] = 0;
            }
        }
    }
}