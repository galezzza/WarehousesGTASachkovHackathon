using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Organizations;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Warehouses
{
    public class OwnedWarehouse : Warehouse, IOwnedProperty
    {
        public Player Owner { get; }
        public int CurrentLoad { get; private set; }

        public OwnedWarehouse(string name, WarehouseType type, int price, Player owner)
            : base(name, type, price)
        {
            Owner = owner;
            CurrentLoad = 0;
        }
        public OwnedWarehouse(Warehouse warehouse, Player owner)
            : this(warehouse.Name, warehouse.Type, warehouse.Price, owner)
        {
            Owner = owner;
            CurrentLoad = 0;
        }

        public void BuyOneCargo()
        {
            AssertIsCEO();
            Owner.Money.SubtractMoney(2000);
            AddCargo(1);
        }
        public void BuyTwoCargo()
        {
            AssertIsCEO();
            Owner.Money.SubtractMoney(8000);
            AddCargo(2);
        }
        public void BuyThreeCargo()
        {
            AssertIsCEO();
            Owner.Money.SubtractMoney(18000);
            AddCargo(3);
        }

        public void Sell20Percent()
        {
            AssertIsCEO();
            int cargoPercent = (int)(CurrentLoad * 0.2);
            CurrentLoad -= cargoPercent;
            int potentialMoney = SellingVehicleWarehouseCargoSite.CalculateMoneyFromSale(cargoPercent);
            Owner.Money.AddMoney(potentialMoney);
        }
        public void Sell50Percent()
        {
            AssertIsCEO();
            int cargoPercent = (int)(CurrentLoad * 0.5);
            CurrentLoad -= cargoPercent;
            int potentialMoney = SellingVehicleWarehouseCargoSite.CalculateMoneyFromSale(cargoPercent);
            Owner.Money.AddMoney(potentialMoney);
        }
        public void SellAll()
        {
            AssertIsCEO();
            int potentialMoney = SellingVehicleWarehouseCargoSite.CalculateMoneyFromSale(CurrentLoad);
            CurrentLoad = 0;
            Owner.Money.AddMoney(potentialMoney);
        }

        private void AssertIsCEO()
        {
            if (Owner.GetActiveOrganization() is SecuroServ)
                throw new InvalidOperationException("Only the CEO can perform this action.");
        }

        public IOwnedProperty AddOwner(Player player)
        {
            throw new InvalidOperationException("Warehouse already has an owner.");
        }

        public int GetCapacityOfCargo() => CapacityOfCargo;
        private void AddCargo(int amount)
        {
            if (CurrentLoad + amount > CapacityOfCargo)
                throw new InvalidOperationException("Not enough space in warehouse.");

            CurrentLoad += amount;
        }
    }

}
