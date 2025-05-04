namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.VehicleWarehouse.Car
{
    public class Plate
    {
        public string PlateText { get; } = GenerateRandomPlateText();

        public Plate(string plateText)
        {
            PlateText = plateText;
        }
        public Plate()
        {
            PlateText = GenerateRandomPlateText();
        }

        static string GenerateRandomPlateText()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 16)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}