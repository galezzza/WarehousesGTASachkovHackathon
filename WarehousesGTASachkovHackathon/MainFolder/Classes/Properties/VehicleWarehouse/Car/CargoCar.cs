namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.VehicleWarehouse.Car
{
    public class CargoCar
    {
        public CargoCarType Type { get; }
        public Vehicle Vehicle { get; }
        public Plate Plate { get; }

        public CargoCar(CargoCarType type, Vehicle vehicle, Plate plate)
        {
            Type = type;
            Vehicle = vehicle;
            Plate = plate;
        }
        public CargoCar(CargoCarType type, Vehicle vehicle)
        {
            Type = type;
            Vehicle = vehicle;
            Plate = new Plate();
        }
        public CargoCar(CargoCarType type, string brand, string model, string plateText)
        {
            Type = type;
            Vehicle = new Vehicle(brand, model);
            Plate = new Plate(plateText);
        }
    }
}