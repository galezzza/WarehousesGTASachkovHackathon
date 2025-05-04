using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Nightclub.Productions.Buisnesses;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Nightclub.Productions
{
    public class NightclubWarehouse
    {
        public int NumberOfFloors { get; private set; } = 1;
        public NightclubUpgrades Upgrades { get; private set; }
            = new NightclubUpgrades();

        public CargoAndShipmentsForNC CargoAndShipments { get; private set; }
        public SportingGoodsForNC SportingGoods { get; private set; }
        public SouthAmericanImportsForNC SouthAmericanImports { get; private set; }
        public PharmacauticalResearchForNC PharmacauticalResearch { get; private set; }
        public OrganicProduceForNC OrganicProduce { get; private set; }
        public PrintingAndCopyingForNC PrintingAndCopying { get; private set; }
        public CashCreationForNC CashCreation { get; private set; }
        

        public NCTechnician Tech1 { get; private set; } = new NCTechnician("Yohan", 0);
        public NCTechnician Tech2 { get; private set; } = new NCTechnician("Tech2", 141000);
        public NCTechnician Tech3 { get; private set; } = new NCTechnician("Tech3", 184500);
        public NCTechnician Tech4 { get; private set; } = new NCTechnician("Tech4", 240500);
        public NCTechnician Tech5 { get; private set; } = new NCTechnician("Tech5", 312000);

        public int boughtTechnicians { get; private set; } = 1;

        public NightclubWarehouse()
        {
            Upgrades = new NightclubUpgrades();
            NumberOfFloors = 1;
            InitializeBuisnesses();
            InitializeTechniciants();
        }
        public NightclubWarehouse(int numberOfFloors)
        {
            if (numberOfFloors < 1) 
            {
                throw new ArgumentException("Number of floors must be at least 1.");
            }    
            else if (numberOfFloors > 5)
            {
                throw new ArgumentException("Number of floors cannot be more than 5.");
            }
            else 
            {
                Upgrades = new NightclubUpgrades();
                NumberOfFloors = numberOfFloors;
                InitializeBuisnesses();
                InitializeTechniciants();
            }
        }

        public void AttachUpgrades(NightclubUpgrades upgrades)
        {
            Upgrades = upgrades;
            CargoAndShipments.AttachUpgrade(upgrades);
            SportingGoods.AttachUpgrade(upgrades);
            SouthAmericanImports.AttachUpgrade(upgrades);
            PharmacauticalResearch.AttachUpgrade(upgrades);
            OrganicProduce.AttachUpgrade(upgrades);
            PrintingAndCopying.AttachUpgrade(upgrades);
            CashCreation.AttachUpgrade(upgrades);
        }
        public void IncreaseNumberOffFloors(int numberOfFloors)
        {
            if (numberOfFloors < 1)
            {
                throw new ArgumentException("Number of floors must be at least 1.");
            }
            else if (numberOfFloors > 5)
            {
                throw new ArgumentException("Number of floors cannot be more than 5.");
            }
            else if (numberOfFloors <= NumberOfFloors)
            {
                throw new ArgumentException("Number of floors can only be increased");
            }
            else
            {
                NumberOfFloors = numberOfFloors;
                CargoAndShipments.UpdateNumberOfFloors(NumberOfFloors, 
                    NCProductionBuisnessType.CargoAndShipments);
                SportingGoods.UpdateNumberOfFloors(NumberOfFloors,
                    NCProductionBuisnessType.SportingGoods);
                SouthAmericanImports.UpdateNumberOfFloors(NumberOfFloors,
                    NCProductionBuisnessType.SouthAmericanImports);
                PharmacauticalResearch.UpdateNumberOfFloors(NumberOfFloors,
                    NCProductionBuisnessType.PharmacauticalResearch);
                OrganicProduce.UpdateNumberOfFloors(NumberOfFloors,
                    NCProductionBuisnessType.OrganicProduce);
                PrintingAndCopying.UpdateNumberOfFloors(NumberOfFloors,
                    NCProductionBuisnessType.PrintingAndCopying);
                CashCreation.UpdateNumberOfFloors(NumberOfFloors,
                    NCProductionBuisnessType.CashCreation);
            }
        }
        
        
        private NCTechnician GetTechnicianByNumber(int number)
        {
            return number switch
            {
                1 => Tech1,
                2 => Tech2,
                3 => Tech3,
                4 => Tech4,
                5 => Tech5,
                _ => throw new ArgumentOutOfRangeException(nameof(number), "Technician number must be between 1 and 5.")
            };
        }
        private NCProductionBuisness GetBuisnessByType(NCProductionBuisnessType type)
        {
            return type switch
            {
                NCProductionBuisnessType.CargoAndShipments => CargoAndShipments,
                NCProductionBuisnessType.SportingGoods => SportingGoods,
                NCProductionBuisnessType.SouthAmericanImports => SouthAmericanImports,
                NCProductionBuisnessType.PharmacauticalResearch => PharmacauticalResearch,
                NCProductionBuisnessType.OrganicProduce => OrganicProduce,
                NCProductionBuisnessType.PrintingAndCopying => PrintingAndCopying,
                NCProductionBuisnessType.CashCreation => CashCreation,
                _ => throw new ArgumentOutOfRangeException("Invalid business type.")
            };
        }

        
        public int BuyNextTechnicianAndReturnItsPrice()
        {
            if (boughtTechnicians >= 5)
            {
                throw new InvalidOperationException("All technicians are already bought.");
            }
            else
            {
                NCTechnician tech = GetTechnicianByNumber(boughtTechnicians + 1);
                tech.BuyTechnician();
                boughtTechnicians++;
                return tech.Price;
            }
        }
        public void MakeBuisnessAvailableByType(NCProductionBuisnessType type)
        {
            NCProductionBuisness buisness = GetBuisnessByType(type);
            buisness.SetAvailable(true);
        }

        private void InitializeBuisnesses()
        {
            CargoAndShipments = new CargoAndShipmentsForNC(NumberOfFloors, Upgrades);
            SportingGoods = new SportingGoodsForNC(NumberOfFloors, Upgrades);
            SouthAmericanImports = new SouthAmericanImportsForNC(NumberOfFloors, Upgrades);
            PharmacauticalResearch = new PharmacauticalResearchForNC(NumberOfFloors, Upgrades);
            OrganicProduce = new OrganicProduceForNC(NumberOfFloors, Upgrades);
            PrintingAndCopying = new PrintingAndCopyingForNC(NumberOfFloors, Upgrades);
            CashCreation = new CashCreationForNC(NumberOfFloors, Upgrades);
        }
        private void InitializeTechniciants()
        {
            Tech1 = new NCTechnician("Yohan", 0);
            Tech2 = new NCTechnician("Tech2", 141000);
            Tech3 = new NCTechnician("Tech3", 184500);
            Tech4 = new NCTechnician("Tech4", 240500);
            Tech5 = new NCTechnician("Tech5", 312000);
        }

       
        public void AllocateTechnicianToBuisness(int technicainNumber, NCProductionBuisnessType type)
        {
            NCProductionBuisness buisness = GetBuisnessByType(type);
            NCTechnician tech = GetTechnicianByNumber(technicainNumber);

            if (!buisness.IsAvailable)
            {
                throw new InvalidOperationException("This business is already allocated to a technician.");
            }
            if (!tech.IsAvailable())
            {
                throw new InvalidOperationException("This technician is not available.");
            }

            tech.AllocateBuisness(buisness);
        }
        public void FreeTechnician(int technicianNumber)
        {
            NCTechnician tech = GetTechnicianByNumber(technicianNumber);
            if (tech.IsAvailable())
            {
                throw new InvalidOperationException("This technician is not allocated to any business.");
            }
            tech.FreeTechnician();
        }
        
        public int GetTotalCapacity()
        {
            int totalCapacity = CargoAndShipments.Capacity + SportingGoods.Capacity +
                     SouthAmericanImports.Capacity + PharmacauticalResearch.Capacity +
                     OrganicProduce.Capacity + PrintingAndCopying.Capacity +
                     CashCreation.Capacity;
            return totalCapacity;
        }
        public int GetCapacityByType(NCProductionBuisnessType type)
        {
            NCProductionBuisness buisness = GetBuisnessByType(type);
            return buisness.Capacity;
        }

        public int SoldCratesByType(NCProductionBuisnessType type)
        {
            NCProductionBuisness buisness = GetBuisnessByType(type);
            int amount = buisness.CurrentLoad;
            buisness.ProductToMin();
            return amount;
        }
        public void SoldCratesByType(NCProductionBuisnessType type, int amount)
        {
            if ((amount < 0) || (amount > GetCapacityByType(type)))
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Incorrent amount of Crates for sale");
            }
            NCProductionBuisness buisness = GetBuisnessByType(type);
            buisness.ReduceSomeProduct(amount);
        }
        public int[] SoldAll()
        {
            int[] currentCarets =
            {
                CargoAndShipments.CurrentLoad,
                SportingGoods.CurrentLoad,
                SouthAmericanImports.CurrentLoad,
                PharmacauticalResearch.CurrentLoad,
                OrganicProduce.CurrentLoad,
                PrintingAndCopying.CurrentLoad,
                CashCreation.CurrentLoad
            };

            CargoAndShipments.ProductToMin();
            SportingGoods.ProductToMin();
            SouthAmericanImports.ProductToMin();
            PharmacauticalResearch.ProductToMin();
            OrganicProduce.ProductToMin();
            PrintingAndCopying.ProductToMin();
            CashCreation.ProductToMin();

            return currentCarets;
        }


    }
}