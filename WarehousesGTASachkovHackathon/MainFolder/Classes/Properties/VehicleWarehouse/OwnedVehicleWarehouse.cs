using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Organizations;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.VehicleWarehouse.Car;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Warehouses;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.VehicleWarehouse
{
    public class OwnedVehicleWarehouse : VehicleWarehouse, IOwnedProperty
    {
        public int TOTAL_TOP_CARS { get; } = 12;
        public int TOTAL_MID_CARS { get; } = 10;
        public int TOTAL_LOW_CARS { get; } = 10;

        public Player Owner { get; }
        public int CurrentLoad { get; private set; }
        
        
        private readonly List<CargoCar> _stoledCargoTopLevelCars = new();
        public IReadOnlyList<CargoCar> GetAllTopCars() => _stoledCargoTopLevelCars.AsReadOnly();

        private readonly List<CargoCar> _stoledCargoMidLevelCars = new();
        public IReadOnlyList<CargoCar> GetAllMidCars() => _stoledCargoMidLevelCars.AsReadOnly();

        private readonly List<CargoCar> _stoledCargoLowLevelCars = new();
        public IReadOnlyList<CargoCar> GetAllLowCars() => _stoledCargoLowLevelCars.AsReadOnly();

        
        public OwnedVehicleWarehouse(string name, int price, Player owner)
            : base(name, price)
        {
            Owner = owner;
            CurrentLoad = 0;
        }
        public OwnedVehicleWarehouse(VehicleWarehouse warehouse, Player owner)
            : base(warehouse.Name, warehouse.Price)
        {
            Owner = owner;
        }

        public IOwnedProperty AddOwner(Player player)
        {
            throw new InvalidOperationException("Vehicle Warehouse already has an owner.");
        }

        public void SourceCargo()
        {
            if (CurrentLoad + 1 > CapacityOfCargoCars)
                throw new InvalidOperationException("Not enough space in warehouse.");

            CargoCarType type = ChooseCargoCarTypeToBeStolen();
            SourceCargoByType(type);
        }

        private CargoCarType ChooseCargoCarTypeToBeStolen()
        {
            bool canBeTopLevel = true;
            bool canBeMidLevel = true;
            bool canBeLowLevel = true;

            if (_stoledCargoTopLevelCars.Count >= TOTAL_TOP_CARS)
            {
                canBeTopLevel = false;
            }
            if (_stoledCargoMidLevelCars.Count >= TOTAL_MID_CARS)
            {
                canBeMidLevel = false;
            }
            if (_stoledCargoLowLevelCars.Count >= TOTAL_LOW_CARS)
            {
                canBeLowLevel = false;
            }

            int[] probability = { TOTAL_LOW_CARS, TOTAL_MID_CARS, TOTAL_TOP_CARS };

            Random rand = new Random();
            int index = rand.Next(3);
            while (true)
            {
                if (probability[index] == 1)
                    break;
            }
            int chosenIndex = index;
            return (CargoCarType)chosenIndex;
        }

        public void SourceCargoByType(CargoCarType type)
        {
            AssertIsCEO();
            if (CurrentLoad + 1 > CapacityOfCargoCars)
                throw new InvalidOperationException("Not enough space in warehouse.");

            switch (type)
            {
                case CargoCarType.Top:
                    if (_stoledCargoTopLevelCars.Count >= TOTAL_TOP_CARS) 
                    { 
                        throw new InvalidOperationException("Not enough space in warehouse.");
                    } 
                    else
                    {
                        _stoledCargoTopLevelCars.Add(CargoVehicleFactory.GetRandomTopTierCar());
                    }
                    break;
                case CargoCarType.Mid:
                    if (_stoledCargoMidLevelCars.Count >= TOTAL_TOP_CARS)
                    {
                        throw new InvalidOperationException("Not enough space in warehouse.");
                    }
                    else
                    {
                        _stoledCargoMidLevelCars.Add(CargoVehicleFactory.GetRandomTopTierCar());
                    }
                    break;
                case CargoCarType.Low:
                    if (_stoledCargoLowLevelCars.Count >= TOTAL_TOP_CARS)
                    {
                        throw new InvalidOperationException("Not enough space in warehouse.");
                    }
                    else
                    {
                        _stoledCargoLowLevelCars.Add(CargoVehicleFactory.GetRandomTopTierCar());
                    }
                    break;
            }
            CurrentLoad += 1;
        }

        private bool IsInTopLevelCars(CargoCar car)
        {
            if ((car.Type == CargoCarType.Top) && _stoledCargoTopLevelCars.Contains(car))
            {
                return true;
            }
            return false;
        }
        private bool IsInMidLevelCars(CargoCar car)
        {
            if ((car.Type == CargoCarType.Mid) && _stoledCargoMidLevelCars.Contains(car))
            {
                return true;
            }
            return false;
        }
        private bool IsInLowLevelCars(CargoCar car)
        {
            if ((car.Type == CargoCarType.Low) && _stoledCargoLowLevelCars.Contains(car))
            {
                return true;
            }
            return false;
        }
        public void SellCargo(CargoCar car, CargoCarBuyerType buyerType)
        {
            AssertIsCEO();
            if (IsInTopLevelCars(car)) 
            {
                _stoledCargoTopLevelCars.Remove(car);
            }
            else if (IsInMidLevelCars(car))
            {
                _stoledCargoMidLevelCars.Remove(car);
            }
            else if (IsInLowLevelCars(car))
            {
                _stoledCargoLowLevelCars.Remove(car);
            }
            else
            {
                throw new InvalidOperationException("Car not found in warehouse.");
            }

            CurrentLoad -= 1;
            int potentialMoney = SellingVehicleWarehouseCargoSite.CalculateMoneyFromSale(car.Type, buyerType);
            Owner.Money.AddMoney(potentialMoney);
        }
        private void AssertIsCEO()
        {
            if (Owner.GetActiveOrganization() is SecuroServ)
                throw new InvalidOperationException("Only the CEO can perform this action.");
        }
    }
}
