using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes
{
    class Session
    {
        public static PlayersContainer PlayersContainer { get; set; }

        public Session()
        {
            PlayersContainer = new PlayersContainer();
        }
    }
}
