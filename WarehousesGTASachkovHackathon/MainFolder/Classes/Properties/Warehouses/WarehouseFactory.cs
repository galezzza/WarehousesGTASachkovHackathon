using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Warehouses
{
    public static class WarehouseFactory
    {
        public static Warehouse CreateByName(string name)
        {
            return name switch
            {
                "ConvenienceStoreLockup" => new Warehouse("Convenience Store Lockup", WarehouseType.Small, 250000),
                "CelltowaUnit" => new Warehouse("Celltowa Unit", WarehouseType.Small, 318000),
                "WhiteWidowGarage" => new Warehouse("White Widow Garage", WarehouseType.Small, 360000),
                "PacificBaitStorage" => new Warehouse("Pacific Bait Storage", WarehouseType.Small, 376000),
                "Pier400UtilityBuilding" => new Warehouse("Pier 400 Utility Building", WarehouseType.Small, 392000),
                "ForeclosedGarage" => new Warehouse("Foreclosed Garage", WarehouseType.Small, 400000),

                "GEEWarehouse" => new Warehouse("GEE Warehouse", WarehouseType.Medium, 880000),
                "DerriereLingerieBacklot" => new Warehouse("Derriere Lingerie Backlot", WarehouseType.Medium, 902000),
                "FridgitAnnexe" => new Warehouse("Fridgit Annexe", WarehouseType.Medium, 925000),
                "DiscountRetailUnit" => new Warehouse("Discount Retail Unit", WarehouseType.Medium, 948000),
                "DisusedFactoryOutlet" => new Warehouse("Disused Factory Outlet", WarehouseType.Medium, 971000),
                "LSMarineBuilding3" => new Warehouse("LS Marine Building 3", WarehouseType.Medium, 994000),
                "OldPowerStation" => new Warehouse("Old Power Station", WarehouseType.Medium, 1000000),
                "RailyardWarehouse" => new Warehouse("Railyard Ware house", WarehouseType.Medium, 1017000),

                "WholesaleFurniture" => new Warehouse("Wholesale Furniture", WarehouseType.Large, 1900000),
                "WestVinewoodBacklot" => new Warehouse("West Vinewood Backlot", WarehouseType.Large, 2135000),
                "XeroGasFactory" => new Warehouse("XeroGas Factory", WarehouseType.Large, 2365000),
                "LogisticsDepot" => new Warehouse("Logistics Depot", WarehouseType.Large, 2600000),
                "BilgecoWarehouse" => new Warehouse("Bilgeco Warehouse", WarehouseType.Large, 2825000),
                "Walker&SonsWarehouse" => new Warehouse("Walker & Sons Warehouse", WarehouseType.Large, 3040000),
                "CypressWarehouses" => new Warehouse("Cypress Warehouses", WarehouseType.Large, 3265000),
                "DarnellBrosWarehouse" => new Warehouse("Darnell Bros Warehouse", WarehouseType.Large, 3500000),
                _ => throw new ArgumentException("Unknown warehouse name.", nameof(name))
            };
        }

        

        public static Warehouse CreateSmallWarehose(string name)
        {
            return name switch
            {
                "ConvenienceStoreLockup" => new Warehouse("Convenience Store Lockup", WarehouseType.Small, 250000),
                "CelltowaUnit" => new Warehouse("Celltowa Unit", WarehouseType.Small, 318000),
                "WhiteWidowGarage" => new Warehouse("White Widow Garage", WarehouseType.Small, 360000),
                "PacificBaitStorage" => new Warehouse("Pacific Bait Storage", WarehouseType.Small, 376000),
                "Pier400UtilityBuilding" => new Warehouse("Pier 400 Utility Building", WarehouseType.Small, 392000),
                "ForeclosedGarage" => new Warehouse("Foreclosed Garage", WarehouseType.Small, 400000),
                _ => throw new ArgumentException("Unknown warehouse name.", nameof(name))
            };
        }
        public static Warehouse CreateMeduimWarehose(string name)
        {
            return name switch
            {
                "GEEWarehouse" => new Warehouse("GEE Warehouse", WarehouseType.Medium, 880000),
                "DerriereLingerieBacklot" => new Warehouse("Derriere Lingerie Backlot", WarehouseType.Medium, 902000),
                "FridgitAnnexe" => new Warehouse("Fridgit Annexe", WarehouseType.Medium, 925000),
                "DiscountRetailUnit" => new Warehouse("Discount Retail Unit", WarehouseType.Medium, 948000),
                "DisusedFactoryOutlet" => new Warehouse("Disused Factory Outlet", WarehouseType.Medium, 971000),
                "LSMarineBuilding3" => new Warehouse("LS Marine Building 3", WarehouseType.Medium, 994000),
                "OldPowerStation" => new Warehouse("Old Power Station", WarehouseType.Medium, 1000000),
                "RailyardWarehouse" => new Warehouse("Railyard Ware house", WarehouseType.Medium, 1017000),
                _ => throw new ArgumentException("Unknown warehouse name.", nameof(name))
            };
        }
        public static Warehouse CreateLargeWarehose(string name)
        {
            return name switch
            {
                "WholesaleFurniture" => new Warehouse("Wholesale Furniture", WarehouseType.Large, 1900000),
                "WestVinewoodBacklot" => new Warehouse("West Vinewood Backlot", WarehouseType.Large, 2135000),
                "XeroGasFactory" => new Warehouse("XeroGas Factory", WarehouseType.Large, 2365000),
                "LogisticsDepot" => new Warehouse("Logistics Depot", WarehouseType.Large, 2600000),
                "BilgecoWarehouse" => new Warehouse("Bilgeco Warehouse", WarehouseType.Large, 2825000),
                "Walker&SonsWarehouse" => new Warehouse("Walker & Sons Warehouse", WarehouseType.Large, 3040000),
                "CypressWarehouses" => new Warehouse("Cypress Warehouses", WarehouseType.Large, 3265000),
                "DarnellBrosWarehouse" => new Warehouse("Darnell Bros Warehouse", WarehouseType.Large, 3500000),
                _ => throw new ArgumentException("Unknown warehouse name.", nameof(name))
            };
        }

        public static Warehouse CreateRandomByType(WarehouseType type)
        {
            var availableWarehouses = type switch
            {
                WarehouseType.Small => GetAvailableSmallWarehouseNames(),
                WarehouseType.Medium => GetAvailableMediumWarehouseNames(),
                WarehouseType.Large => GetAvailableLargeWarehouseNames(),
                _ => throw new ArgumentException("Unknown warehouse type.", nameof(type))
            };
            var randomName = availableWarehouses[new Random().Next(availableWarehouses.Count)];
            return CreateByName(randomName);
        }

        public static IReadOnlyList<string> GetAvailableWarehouseNames()
        => new List<string>
        {
            "ConvenienceStoreLockup",
            "CelltowaUnit",
            "WhiteWidowGarage",
            "PacificBaitStorage",
            "Pier400UtilityBuilding",
            "ForeclosedGarage",
            
            "GEEWarehouse",
            "DerriereLingerieBacklot",
            "FridgitAnnexe",
            "DiscountRetailUnit",
            "DisusedFactoryOutlet",
            "LSMarineBuilding3",
            "OldPowerStation",
            "RailyardWarehouse",

            "WholesaleFurniture",
            "WestVinewoodBacklot",
            "XeroGasFactory",
            "LogisticsDepot",
            "BilgecoWarehouse",
            "Walker&SonsWarehouse",
            "CypressWarehouses",
            "DarnellBrosWarehouse"
        };
        public static IReadOnlyList<string> GetAvailableSmallWarehouseNames()
        => new List<string>
        {
            "ConvenienceStoreLockup",
            "CelltowaUnit",
            "WhiteWidowGarage",
            "PacificBaitStorage",
            "Pier400UtilityBuilding",
            "ForeclosedGarage",
        };

        public static IReadOnlyList<string> GetAvailableMediumWarehouseNames()
        => new List<string>
        {
            "GEEWarehouse",
            "DerriereLingerieBacklot",
            "FridgitAnnexe",
            "DiscountRetailUnit",
            "DisusedFactoryOutlet",
            "LSMarineBuilding3",
            "OldPowerStation",
            "RailyardWarehouse",
        };

        public static IReadOnlyList<string> GetAvailableLargeWarehouseNames()
        => new List<string>
        { 
            "WholesaleFurniture",
            "WestVinewoodBacklot",
            "XeroGasFactory",
            "LogisticsDepot",
            "BilgecoWarehouse",
            "Walker&SonsWarehouse",
            "CypressWarehouses",
            "DarnellBrosWarehouse"
        };
    }

}
