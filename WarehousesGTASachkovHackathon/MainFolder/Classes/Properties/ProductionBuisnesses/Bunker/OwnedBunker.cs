using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Organizations;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub.Buisnesses;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Bunker
{
    public class OwnedBunker : OwnedProductionBuisness
    {
        public override StocksProductionLogic Stocks { get; }
        public override BunkerProductionUpgrades Upgrades { get; }
        public Player Owner { get; private set; }

        public OwnedBunker(string name, int price, Player owner)
            : base(name, price, owner)
        {
            Owner = owner;
            Stocks = StocksProductionLogicFactory.CreateForBunker();
            Upgrades = new BunkerProductionUpgrades();
        }
        public OwnedBunker(ProductionBuisness productionBuisness, Player owner)
            : base(productionBuisness.Name, productionBuisness.Price, owner)
        {
            Owner = owner;
            Stocks = StocksProductionLogicFactory.CreateForBunker();
            Upgrades = new BunkerProductionUpgrades();
        }
        public OwnedBunker(string name, int price, Player owner, BunkerProductionUpgrades upgrades)
            : base(name, price, owner, upgrades)
        {
            Owner = owner;
            Stocks = StocksProductionLogicFactory.CreateForBunker();
            Upgrades = upgrades;
        }
        public override int CaltulateSellMoney(SellDistance sellDistance)
        {
            return SellingBunkerStockSiteSellingBunkerStockSite.CalculateMoneyFromSale(Stocks.Product, sellDistance, Upgrades);
        }

        protected override void AssertOrganizationLeader()
        {
            AssertIsAnyOrganizationLeader();
        }

        private void AssertIsAnyOrganizationLeader()
        {
            try
            {
                Owner.GetActiveOrganization();
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("Only the President of Motoclub can perform this action.");
            }
        }

    }
}
