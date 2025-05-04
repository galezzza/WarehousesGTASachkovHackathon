using WarehousesGTASachkovHackathon.MainFolder.Classes;

namespace WarehousesGTASachkovHackathon.MainFolder.Interfaces
{
    public interface IOwnedProperty : IProperty
    {
        Player Owner { get; }
    }
}