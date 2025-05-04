using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Hangar
{
    public class OwnedHangar : Hangar, IOwnedProperty
    {
        public Player Owner { get; }
        public HangarWarehouse HangarWarehouse { get; private set; } 
            = new HangarWarehouse();


        public OwnedHangar(Hangar hangar, Player player) 
            : base(hangar.Name, hangar.Price)
        {
            Owner = player;
            HangarWarehouse = new HangarWarehouse();
        }
        public OwnedHangar(string name, int price, Player player) 
            : base(name, price)
        {
            Owner = player;
            HangarWarehouse = new HangarWarehouse();
        }

        public void StealSupplies(BunkerCargo cargo, int amount, IOrganization organization)
        {
            AssertOrganizationLeader();
            if (organization.NumberOfEmployees <= 4)
            {
                HangarWarehouse.AddCargo(cargo, organization.NumberOfEmployees);
            }
            else if (organization.NumberOfEmployees > 4)
            {
                HangarWarehouse.AddCargo(cargo, 4);
            }
            else
            {
                throw new InvalidOperationException("Invalid number of employees.");
            }
        }

        public void SellAllSupplies()
        {
            AssertOrganizationLeader();
            int money = SellingHangarStockSite.CalculateMoneyFromAllCargoSale(HangarWarehouse);
            Owner.Money.AddMoney(money);
        }

        public void SellSuppliesByType(BunkerCargo type)
        {
            AssertOrganizationLeader();
            int cargoAmount = HangarWarehouse.GetCargoAmountByType(type);
            int money = SellingHangarStockSite.CalculateMoneyFromSaleByType(cargoAmount, type);
            HangarWarehouse.RemoveCargo(type);
            Owner.Money.AddMoney(money);
        }

        private void AssertOrganizationLeader()
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

        public IOwnedProperty AddOwner(Player player)
        {
            throw new InvalidOperationException("This business already has an owner.");
        }
    }
}
