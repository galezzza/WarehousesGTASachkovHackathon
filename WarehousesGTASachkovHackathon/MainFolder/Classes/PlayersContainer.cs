using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes
{
    public class PlayersContainer : IPlayersContainer
    {
        public int MAX_PLAYERS = 30;
        private List<Player> players = new List<Player>();

        public PlayersContainer()
        {
            players = new List<Player>();
        }
        public void AddPlayer(string username, Player player)
        {
            if (players.Count >= MAX_PLAYERS)
            {
                throw new Exception("Maximum number of players reached!");
            }
            if (players.Any(p => p.Nickname == username))
            {
                throw new Exception("User already exists!");
            }
            else
            {
                players.Add(player);
            }
        }

        public Player GetPlayer(string username)
        {
            var player = players.FirstOrDefault(p => p.Nickname == username);

            if (player != null)
            {
                return player;
            }
            else
            {
                throw new Exception("User not found!");
            }
        }

        public void RemovePlayer(string username)
        {
            var player = players.FirstOrDefault(p => p.Nickname == username);

            if (player != null)
            {
                players.Remove(player);
            }
            else
            {
                throw new Exception("User not found!");
            }
        }
    }
}