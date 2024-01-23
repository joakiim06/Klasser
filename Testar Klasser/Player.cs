using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Testar_Klasser
{
    internal class Player
    {
        private string name;
        private int kills;
        
        public void setPlayerName(string tmpPlayerName)
        {
            name = tmpPlayerName;
        }

        public string getPlayerName()
        {
            return name;
        }

        public Player(string name, int kills)
        {
            this.name = name;
            this.kills = kills;
        }

        public string ToString()
        {
            return $@"Användarnamn: {name}
Kills: {kills}"; //Har detta för att den ska bryta efter användarnamnet för att det ska bli lättare att läsa helt enkelt
        }
    }
}
