namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.VehicleWarehouse.Car
{
    public class Vehicle
    {
        public string Manufacturer { get; }
        public string Model { get; }

        public Vehicle(string manufacturer, string model)
        {
            Manufacturer = manufacturer;
            Model = model;
        }
    }
}