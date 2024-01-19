using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testar_Klasser
{
    internal class Lobby
    {
        private List<Player> players;

        public Lobby()
        {
            players = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public List<string> GetPlayersAsString() 
        {
            List<string> result = new List<string>();
            foreach (Player player in players)
            {
                result.Add(player.ToString());
            }
            return result;

        }

    }
}
