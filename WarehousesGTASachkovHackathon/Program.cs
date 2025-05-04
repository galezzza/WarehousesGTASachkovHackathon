using WarehousesGTASachkovHackathon.MainFolder.Classes;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Organizations;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Hangar;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Nightclub;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Nightclub.Productions;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Bunker;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub.Buisnesses;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.VehicleWarehouse;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Warehouses;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

Session session = new Session();

Player player = new Player("Player1", int.MaxValue);

WarehouseSeller warehouseSeller = new WarehouseSeller();
VehicleWarehouseSeller vehicleWarehouseSeller = new VehicleWarehouseSeller();
MCBuisnessSeller mcBuisnessSeller = new MCBuisnessSeller();
BunkerSeller bunkerSeller = new BunkerSeller();
HangarSeller hangarSeller = new HangarSeller();
NightclubSeller nightclubSeller = new NightclubSeller();

Motoclub motoclub = new Motoclub();
player.AddOrganization(motoclub);
SecuroServ securoServ = new SecuroServ();
player.AddOrganization(securoServ);

warehouseSeller.Buy(player, WarehouseType.Large);
warehouseSeller.Buy(player, WarehouseType.Small);

//player.DeactivateOrganization<SecuroServ>();
player.ActivateOrganization<Motoclub>();

mcBuisnessSeller.Buy(MCBuisnessType.MethamphetamineLab, MCBuisnessLocations.City, player);
mcBuisnessSeller.Buy(MCBuisnessType.CocaineLockup, MCBuisnessLocations.City, player);
mcBuisnessSeller.Buy(MCBuisnessType.CounterfeitCashFactory, MCBuisnessLocations.City, player);
mcBuisnessSeller.Buy(MCBuisnessType.WeedFarm, MCBuisnessLocations.City, player);
mcBuisnessSeller.Buy(MCBuisnessType.DocumentForgeryOffice, MCBuisnessLocations.City, player);

var nightclubs = nightclubSeller.GetCatalog();
nightclubSeller.Buy(nightclubs[0], player);


player.ActivateOrganization<Motoclub>();

Console.WriteLine(player.Properties.GetAllNightClubs());

Console.WriteLine("Sucess\n");

player.Properties.GetAllNightClubs().FirstOrDefault().BuyNextTech();
player.Properties.GetAllNightClubs().FirstOrDefault().BuyNextTech();
player.Properties.GetAllNightClubs().FirstOrDefault().BuyNextTech();
player.Properties.GetAllNightClubs().FirstOrDefault().BuyNextTech();


player.Properties.GetAllNightClubs().FirstOrDefault()
    .AllocateTechnicianToBuisness(1, NCProductionBuisnessType.CargoAndShipments);
player.Properties.GetAllNightClubs().FirstOrDefault()
    .AllocateTechnicianToBuisness(2, NCProductionBuisnessType.PrintingAndCopying);
player.Properties.GetAllNightClubs().FirstOrDefault()
    .AllocateTechnicianToBuisness(3, NCProductionBuisnessType.OrganicProduce);
player.Properties.GetAllNightClubs().FirstOrDefault()
    .AllocateTechnicianToBuisness(4, NCProductionBuisnessType.SouthAmericanImports);

while (true)
{
    Console.WriteLine(player.Properties.GetAllNightClubs()[0].NightclubWarehouse.CargoAndShipments.CurrentLoad);
    Console.WriteLine(player.Properties.GetAllNightClubs()[0].NightclubWarehouse.SportingGoods.CurrentLoad);

    Console.WriteLine(player.Properties.GetAllNightClubs()[0].NightclubWarehouse.CashCreation.CurrentLoad);
    Console.WriteLine(player.Properties.GetAllNightClubs()[0].NightclubWarehouse.OrganicProduce.CurrentLoad);
    Console.WriteLine(player.Properties.GetAllNightClubs()[0].NightclubWarehouse.SouthAmericanImports.CurrentLoad);
    Console.WriteLine(player.Properties.GetAllNightClubs()[0].NightclubWarehouse.PrintingAndCopying.CurrentLoad);
    Console.WriteLine(player.Properties.GetAllNightClubs()[0].NightclubWarehouse.PharmacauticalResearch.CurrentLoad);

    Thread.Sleep(4);
    Console.Clear();
}