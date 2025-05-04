using WarehousesGTASachkovHackathon.MainFolder.Classes;

namespace WarehousesGTASachkovHackathon.MainFolder.Interfaces
{
    public interface IPlayersContainer
    {
        Player GetPlayer(string username);
        void AddPlayer(string username, Player player);
        void RemovePlayer(string username);
    }
}