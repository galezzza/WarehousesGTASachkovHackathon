using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses
{
    public abstract class OwnedProductionBuisness : ProductionBuisness, IOwnedProperty
    {
        public Player Owner { get; private set; }
        abstract public StocksProductionLogic Stocks { get; }
        abstract public ProductionUpgrades Upgrades { get; }


        public OwnedProductionBuisness(string name, int price, Player owner)
            : base(name, price)
        {
            Owner = owner;
        }
        public OwnedProductionBuisness(ProductionBuisness productionBuisness, Player owner)
            : base(productionBuisness.Name, productionBuisness.Price)
        {
            Owner = owner;
        }
        public OwnedProductionBuisness(string name, int price, Player owner, ProductionUpgrades upgrades)
            : base(name, price)
        {
            Owner = owner;
        }


        public void UpgradeEquipment()
        {
            Upgrades.UpgradeEquipment();
            Stocks.ReduceTimeToProduce(Upgrades.ReduceSingleUnitProductionTime);
            Owner.Money.SubtractMoney(Upgrades.EquipmentUpgradePrice);
        }
        public void UpgradeStaff()
        {
            Upgrades.UpgradeStaff();
            Stocks.ReduceTimeToProduce(Upgrades.ReduceSingleUnitProductionTime);
            Owner.Money.SubtractMoney(Upgrades.StaffUpgradePrice);
        }
        public void Produce()
        {
            Stocks.Produce();
        }

        public void BuySupplies()
        {
            AssertOrganizationLeader();
            Stocks.SuppliesToMax();
            int moneyToSpend = Stocks.CalculateSuppliesToBuy();
            Owner.Money.SubtractMoney(moneyToSpend);
        }

        public void StealSupplies()
        {
            AssertOrganizationLeader();
            Stocks.SuppliesToMax();
        }

        public void SellProduct(SellDistance sellDistance)
        {
            AssertOrganizationLeader();
            int moneyToAdd = CaltulateSellMoney(sellDistance);
            Stocks.ProductToMin();
        }

        abstract public int CaltulateSellMoney(SellDistance sellDistance);

        abstract protected void AssertOrganizationLeader();

        public override IOwnedProperty AddOwner(Player player)
        {
            throw new InvalidOperationException("This business already has an owner.");
        }

    }
}
