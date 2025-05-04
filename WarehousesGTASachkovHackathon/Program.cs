using WarehousesGTASachkovHackathon.MainFolder.Classes;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Motorclub.Buisnesses;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Warehouses;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

Session session = new Session();
Warehouse warehouse = WarehouseFactory.CreateByName("Large Warehouse");


Player player = new Player("Player1", 1000001);

//var ownedProperty = (OwnedWarehouse)player.BuyNewProperty(warehouse);

//ownedProperty.BuyOneCargo();

//Console.WriteLine($"Player: {player.Money.GetMoney()}");

//ownedProperty.BuyTwoCargo();

//Console.WriteLine($"{player.Money.GetMoney()}");
//Console.WriteLine($"{ownedProperty.CurrentLoad}");

//ownedProperty.BuyThreeCargo();
//ownedProperty.BuyThreeCargo();
//ownedProperty.BuyThreeCargo();
//ownedProperty.BuyThreeCargo();
//ownedProperty.BuyThreeCargo();
//ownedProperty.BuyThreeCargo();
//ownedProperty.BuyThreeCargo();

//Console.WriteLine($"{player.Money.GetMoney()}");
//Console.WriteLine($"{ownedProperty.CurrentLoad}");

//ownedProperty.SellAll();

//Console.WriteLine($"{player.Money.GetMoney()}");
//Console.WriteLine($"{ownedProperty.CurrentLoad}");

WeedFarm weed = new WeedFarm("dasda", 1);
var ownedProperty = (OwnedWeedFarm)player.BuyNewProperty(weed);

Console.WriteLine(ownedProperty);