using System.Reflection.Metadata.Ecma335;

namespace Testar_Klasser
{
    internal class Program
    {
        static void Main()
        {
            Lobby lobby = new Lobby();

            lobby.AddPlayer(new Player("Joocke", 1337));
            lobby.AddPlayer(new Player("BearHero", 2));
            lobby.AddPlayer(new Player("xXx_yes_xXx", 0));

            string[] randomNames = { "xredbullgerdigvingar1337x", "xXx_integralkalkylensfundamentalsats_xXx", "pq-formeln1337" };
            
            Random rdm = new Random();
            int index = rdm.Next(randomNames.Length);
            string randomName = randomNames[index];

            int randomKills = rdm.Next(0,1000);

            lobby.AddPlayer(new Player(randomName, randomKills));
     
            foreach (string player in lobby.GetPlayersAsString())
            {
                Console.WriteLine(player);
            }
        }


    }
}
