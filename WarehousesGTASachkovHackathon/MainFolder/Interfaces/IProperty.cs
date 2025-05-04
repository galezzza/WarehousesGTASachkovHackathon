using WarehousesGTASachkovHackathon.MainFolder.Classes;

namespace WarehousesGTASachkovHackathon.MainFolder.Interfaces
{
    public interface IProperty
    {
        string Name { get; }
        int Price { get; }
        IOwnedProperty AddOwner(Player player);
    }
}