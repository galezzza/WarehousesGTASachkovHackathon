using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Hangar;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Nightclub.Productions;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Nightclub
{
    public class OwnedNightclub : Nightclub, IOwnedProperty
    {
        public Player Owner { get; }
        public NightclubUpgrades Upgrades { get; private set; }
            = new NightclubUpgrades();
        public NightclubWarehouse NightclubWarehouse { get; private set; }
            = new NightclubWarehouse();

        public OwnedNightclub(Nightclub nightclub, Player player)
            : base(nightclub.Name, nightclub.Price)
        {
            Owner = player;
            NightclubWarehouse = new NightclubWarehouse();
            Upgrades = new NightclubUpgrades();
        }
        public OwnedNightclub(string name, int price, Player player)
            : base(name, price)
        {
            Owner = player;
            NightclubWarehouse = new NightclubWarehouse();
            Upgrades = new NightclubUpgrades();
        }

        public void BuyFloors(int number)
        {
            NightclubWarehouse.IncreaseNumberOffFloors(number);
            int money = number switch
            {
                2 => 809750,
                3 => 1245250,
                4 => 1702550,
                5 => 1975000,
                _ => throw new ArgumentException("Invalid number of floors.")
            };
            Owner.Money.SubtractMoney(money);
        }

        public void UpgradeEquipment()
        {
            AssertOrganizationLeader();
            Upgrades.UpgradeEquipment();
            NightclubWarehouse.AttachUpgrades(Upgrades);
            Owner.Money.SubtractMoney(Upgrades.EquipmentUpgradePrice);
        }
        public void UpgradeStaff()
        {
            AssertOrganizationLeader();
            Upgrades.UpgradeStaff();
            NightclubWarehouse.AttachUpgrades(Upgrades);
            Owner.Money.SubtractMoney(Upgrades.StaffUpgradePrice);
        }
        public void UpgradeSecurity()
        {
            AssertOrganizationLeader();
            Upgrades.UpgradeSecurity();
            NightclubWarehouse.AttachUpgrades(Upgrades);
            Owner.Money.SubtractMoney(Upgrades.SecurityUpgradePrice);
        }

        public void BuyNextTech()
        {
            AssertOrganizationLeader();
            int money = NightclubWarehouse.BuyNextTechnicianAndReturnItsPrice();
            Owner.Money.SubtractMoney(money);
        }
        public void MakeBuisnessAvailableByType(NCProductionBuisnessType type)
        {
            AssertOrganizationLeader();
            NightclubWarehouse.MakeBuisnessAvailableByType(type);
        }

        public void AllocateTechnicianToBuisness(int technicianNumber, NCProductionBuisnessType type)
        {
            AssertOrganizationLeader();
            NightclubWarehouse.AllocateTechnicianToBuisness(technicianNumber, type);
        }
        public void FreeTechnician(int technicianNumber)
        {
            AssertOrganizationLeader();
            NightclubWarehouse.FreeTechnician(technicianNumber);
        }


        public int GetTotalCapacity()
        {
            return NightclubWarehouse.GetTotalCapacity();
        }

        public int GetCapacityByType(NCProductionBuisnessType type)
        {
            return NightclubWarehouse.GetCapacityByType(type);
        }

        public void SoldCrateByType(NCProductionBuisnessType type)
        {
            AssertOrganizationLeader();
            
            int soldedAmount =  NightclubWarehouse.SoldCratesByType(type);
            int money = SellingNightclubStockSite.CalculateMoneyByType(soldedAmount, type);
            
            Owner.Money.AddMoney(money);
        }
        public void SoldCrateByType(NCProductionBuisnessType type, int amount)
        {
            AssertOrganizationLeader();

            NightclubWarehouse.SoldCratesByType(type, amount);

            int money = SellingNightclubStockSite.CalculateMoneyByType(amount, type);
            Owner.Money.AddMoney(money);
        }

        public void SoldAll()
        {
            AssertOrganizationLeader();
            int[] soldedAmount = NightclubWarehouse.SoldAll();
            int money = SellingNightclubStockSite.CalulateMoneyFromSellingAllTypes(soldedAmount);
            Owner.Money.AddMoney(money);
        }

        protected void AssertOrganizationLeader()
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
