using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Motorclub.Buisnesses.CashFactory;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Motorclub
{
    public abstract class OwnedMCProductionBuisness : MCProductionBuisness, IOwnedProperty
    {
        public Player Owner { get; private set;  }
        public StocksProductionLogic Stocks { get; private set; }
        public ProductionUpgrades Upgrades { get; private set; }

        public OwnedMCProductionBuisness(string name, int price, MCBuisnessesType type, Player owner)
            : base(name, price, type)
        {
            Owner = owner;
            Stocks = StocksProductionLogicFactory.CreateByType(type);
            Upgrades = new ProductionUpgrades(type);
        }
        public OwnedMCProductionBuisness(MCProductionBuisness productionBuisness, Player owner)
            : base(productionBuisness.Name, productionBuisness.Price, productionBuisness.Type)
        {
            Owner = owner;
            Stocks = StocksProductionLogicFactory.CreateByType(productionBuisness.Type);
            Upgrades = new ProductionUpgrades(productionBuisness.Type);
        }
        public OwnedMCProductionBuisness(string name, int price, Player owner, ProductionUpgrades upgrades)
            : base(name, price, upgrades.Type)
        {
            Owner = owner;
            Stocks = StocksProductionLogicFactory.CreateByType(upgrades.Type);
            Upgrades = upgrades;
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

        public void BuySupplies()
        {
            Stocks.SuppliesToMax();
            int moneyToSpend = Stocks.CalculateSuppliesToBuy();
            Owner.Money.SubtractMoney(moneyToSpend);
        }

        public void StealSupplies()
        {
            Stocks.SuppliesToMax();
        }
        
        public void Produce()
        {
            Stocks.Produce();
        }

        public void SellProduct()
        {
            int moneyToAdd = (int)(Stocks.Product * 100);
            Stocks.ProductToMin();
        }

        public override IOwnedProperty AddOwner(Player player)
        {
            throw new InvalidOperationException("This business already has an owner.");
        }
    }
}
