using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Organizations;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Bunker;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub
{
    public abstract class OwnedMCProductionBuisness : OwnedProductionBuisness, IOwnedProperty
    {
        public Player Owner { get; private set;  }
        public override StocksProductionLogic Stocks { get; }
        public override MCProductionUpgrades Upgrades { get; }
        public MCBuisnessType Type { get; private set; }

        public OwnedMCProductionBuisness(string name, int price, MCBuisnessType type, Player owner)
            : base(name, price, owner)
        {
            Owner = owner;
            Stocks = StocksProductionLogicFactory.CreateByMCType(type);
            Upgrades = new MCProductionUpgrades(type);
            Type = type;
        }
        public OwnedMCProductionBuisness(MCProductionBuisness productionBuisness, Player owner)
            : base(productionBuisness.Name, productionBuisness.Price, owner)
        {
            Owner = owner;
            Stocks = StocksProductionLogicFactory.CreateByMCType(productionBuisness.Type);
            Upgrades = new MCProductionUpgrades(productionBuisness.Type);
        }
        public OwnedMCProductionBuisness(string name, int price, Player owner, MCProductionUpgrades upgrades)
            : base(name, price, owner, upgrades)
        {
            Owner = owner;
            Stocks = StocksProductionLogicFactory.CreateByMCType(upgrades.Type);
            Upgrades = upgrades;
        }

        public override int CaltulateSellMoney(SellDistance sellDistance)
        {
            return SellingMCProductionStockSite.CalculateMoneyFromSale(
                Type,
                Stocks.Product,
                sellDistance,
                Upgrades);
        }
        protected override void AssertOrganizationLeader()
        {
            AssertIsPresident();
        }

        private void AssertIsPresident()
        {
            if (Owner.GetActiveOrganization() is Motoclub)
                throw new InvalidOperationException("Only the President of Motoclub can perform this action.");
        }

        public override IOwnedProperty AddOwner(Player player)
        {
            throw new InvalidOperationException("This business already has an owner.");
        }
    }
}
