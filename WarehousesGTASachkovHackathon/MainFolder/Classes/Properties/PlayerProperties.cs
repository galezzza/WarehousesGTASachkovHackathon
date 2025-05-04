using System.Buffers;
using System.ComponentModel.DataAnnotations;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Motorclub;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Warehouses;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties
{
    public class PlayerProperties
    {
        private readonly int MAX_WAREHOUSES = 5;

        private readonly List<OwnedWarehouse> _warehouseProperties = new();
        public IReadOnlyList<OwnedWarehouse> GetAllWarehouses() => _warehouseProperties.AsReadOnly();


        private readonly List<OwnedMCProductionBuisness> _propertiesOfMC = new();
        public IReadOnlyList<OwnedMCProductionBuisness> GetAllMC() => _propertiesOfMC.AsReadOnly();

        public void AddProperty(IOwnedProperty property)
        {
            switch (property)
            {
                case OwnedWarehouse warehouse:
                    
                    AddWarehouse(warehouse);
                    break;

                case OwnedMCProductionBuisness productionBuisness:
                    AddMC(productionBuisness);
                    break;

                default:
                    throw new InvalidOperationException($"Unsupported property type: {property.GetType().Name}");
            }
        }

        private void AddWarehouse(OwnedWarehouse warehouse)
        {
            if (_warehouseProperties.Count >= MAX_WAREHOUSES)
                throw new InvalidOperationException("Maximum number of warehouses reached.");
            if (_warehouseProperties.Any(w => w.Name == warehouse.Name))
                throw new InvalidOperationException("Warehouse with this name already exists.");
            _warehouseProperties.Add(warehouse);
        }

        private void AddMC(OwnedMCProductionBuisness productionBuisness)
        {
            if (_warehouseProperties.Count >= MAX_WAREHOUSES)
                throw new InvalidOperationException("Maximum number of warehouses reached.");
            if (_warehouseProperties.Any(w => w.Name == productionBuisness.Name))
                throw new InvalidOperationException("Warehouse with this name already exists.");
            _propertiesOfMC.Add(productionBuisness);
        }

        public PlayerProperties()
        {
            _warehouseProperties = new List<OwnedWarehouse>();
        }
    }
}