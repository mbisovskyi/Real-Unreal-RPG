using RealUnrealRPG.Interfaces;

namespace RealUnrealRPG.Classes
{
    internal class Player : IPlayer
    {
        public string PlayerName = "";

        public Player()
        {
            GetPlayerName();
        }

        public void GetPlayerName()
        {
            Console.WriteLine("Please, enter player name: \n");
            var playerName = Console.ReadLine();
            if (playerName == null)
            {
                PlayerName = "Anonemous";
            }
            else {
                PlayerName = playerName;
            }
        }
    }
}
