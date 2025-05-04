using System.Buffers;
using System.ComponentModel.DataAnnotations;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Hangar;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Nightclub;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Nightclub.Productions;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Bunker;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.VehicleWarehouse;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Warehouses;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties
{
    public class PlayerProperties
    {
        private readonly int MAX_WAREHOUSES = 5;
        private readonly int MAX_VEHICLE_WAREHOUSES = 1;
        private readonly int MAX_BUNKERS = 1;
        private readonly int MAX_HANGARS = 1;
        private readonly int MAX_NIGHT_CLUBS = 1;




        private readonly List<OwnedWarehouse> _warehouseProperties = new();
        public IReadOnlyList<OwnedWarehouse> GetAllWarehouses() => _warehouseProperties.AsReadOnly();


        private readonly List<OwnedVehicleWarehouse> _vehicleWarehouseProperties = new();
        public IReadOnlyList<OwnedVehicleWarehouse> GetAllVehiceWarehouses() => _vehicleWarehouseProperties.AsReadOnly();


        private readonly List<OwnedMCProductionBuisness> _propertiesOfMC = new();
        public IReadOnlyList<OwnedMCProductionBuisness> GetAllMC() => _propertiesOfMC.AsReadOnly();


        private readonly List<OwnedBunker> _bunkerProperties = new();
        public IReadOnlyList<OwnedBunker> GetAllBunkers() => _bunkerProperties.AsReadOnly();


        private readonly List<OwnedHangar> _hangarsProperties = new();
        public IReadOnlyList<OwnedHangar> GetAllHangars() => _hangarsProperties.AsReadOnly();


        private readonly List<OwnedNightclub> _nightClubProperties = new();
        public IReadOnlyList<OwnedNightclub> GetAllNightClubs() => _nightClubProperties.AsReadOnly();


        public void AddProperty(IOwnedProperty property)
        {
            switch (property)
            {
                case OwnedWarehouse warehouse:
                    AddWarehouse(warehouse);
                    break;

                case OwnedVehicleWarehouse vehicleWarehouse:
                    AddVehicleWarehouse(vehicleWarehouse);
                    break;

                case OwnedMCProductionBuisness productionBuisness:
                    AddMC(productionBuisness);
                    break;
                case OwnedBunker bunker:
                    AddBunker(bunker);
                    break;
                case OwnedHangar hangar:
                    AddHangar(hangar);
                    break;
                case OwnedNightclub nightClub:
                    AddNightClub(nightClub);
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
            MakeNightclubPropertyAvailable(NCProductionBuisnessType.CargoAndShipments);
        }
        private void AddVehicleWarehouse(OwnedVehicleWarehouse warehouse)
        {
            if (_vehicleWarehouseProperties.Count >= MAX_VEHICLE_WAREHOUSES)
                throw new InvalidOperationException("Maximum number of vehicle warehouses reached.");
            if (_vehicleWarehouseProperties.Any(w => w.Name == warehouse.Name))
                throw new InvalidOperationException("Vehicle Warehouse with this name already exists.");
            _vehicleWarehouseProperties.Add(warehouse);
        }
        private void AddBunker(OwnedBunker bunker)
        {
            if (_bunkerProperties.Count >= MAX_BUNKERS)
                throw new InvalidOperationException("Maximum number of bunkers reached.");
            if (_bunkerProperties.Any(w => w.Name == bunker.Name))
                throw new InvalidOperationException("Bunker with this name already exists.");
            _bunkerProperties.Add(bunker);
            MakeNightclubPropertyAvailable(NCProductionBuisnessType.SportingGoods);
        }

        private void AddMC(OwnedMCProductionBuisness productionBuisness)
        {
            if (_propertiesOfMC.Any(w => w.GetType() == productionBuisness.GetType()))
                throw new InvalidOperationException($"You already have {productionBuisness.GetType()}.");

            if (_propertiesOfMC.Any(w => w.Name == productionBuisness.Name))
                throw new InvalidOperationException("Warehouse with this name already exists.");
            _propertiesOfMC.Add(productionBuisness);

            MakeNightclubPropertyAvailable(ConvertMNTypeIntoNCType(productionBuisness.Type));
        }


        private void AddHangar(OwnedHangar hangar)
        {
            if (_hangarsProperties.Count >= MAX_HANGARS)
                throw new InvalidOperationException("Maximum number of hangars reached.");
            if (_hangarsProperties.Any(w => w.Name == hangar.Name))
                throw new InvalidOperationException("Hangar with this name already exists.");
            _hangarsProperties.Add(hangar);
        }
        private void AddNightClub(OwnedNightclub nightClub)
        {
            if (_nightClubProperties.Count >= MAX_NIGHT_CLUBS)
                throw new InvalidOperationException("Maximum number of Night clubs reached.");
            if (_nightClubProperties.Any(w => w.Name == nightClub.Name))
                throw new InvalidOperationException("Night club with this name already exists.");
            _nightClubProperties.Add(nightClub);

            MakeNightclubPropertyAvailable();
        }

        private void MakeNightclubPropertyAvailable(NCProductionBuisnessType type)
        {
            if (_nightClubProperties.Count != 0) 
            {
                OwnedNightclub? ownedNightclub = _nightClubProperties.FirstOrDefault();
                if (ownedNightclub != null)
                {
                    ownedNightclub.MakeBuisnessAvailableByType(type);
                }
            }
        }
        private void MakeNightclubPropertyAvailable()
        {
            if (_nightClubProperties.Count != 0)
            {
                OwnedNightclub? ownedNightclub = _nightClubProperties.FirstOrDefault();
                if (ownedNightclub != null)
                {
                    if(_warehouseProperties.Count > 0)
                    {
                        ownedNightclub.MakeBuisnessAvailableByType(NCProductionBuisnessType.CargoAndShipments);
                    }
                    if (_bunkerProperties.Count > 0)
                    {
                        ownedNightclub.MakeBuisnessAvailableByType(NCProductionBuisnessType.SportingGoods);
                    }
                    if (_propertiesOfMC.Count > 0)
                    {
                        foreach (var mc in _propertiesOfMC)
                        {
                            ownedNightclub.MakeBuisnessAvailableByType(ConvertMNTypeIntoNCType(mc.Type));
                        }
                    }
                }
            }
        }

        private NCProductionBuisnessType ConvertMNTypeIntoNCType(MCBuisnessType type)
        {
            return type switch
            {
                MCBuisnessType.CocaineLockup => NCProductionBuisnessType.SouthAmericanImports,
                MCBuisnessType.MethamphetamineLab => NCProductionBuisnessType.PharmacauticalResearch,
                MCBuisnessType.CounterfeitCashFactory => NCProductionBuisnessType.CashCreation,
                MCBuisnessType.DocumentForgeryOffice=> NCProductionBuisnessType.PrintingAndCopying,
                MCBuisnessType.WeedFarm => NCProductionBuisnessType.OrganicProduce,
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
        }

        public PlayerProperties()
        {
            _warehouseProperties = new List<OwnedWarehouse>();
        }
    }
}