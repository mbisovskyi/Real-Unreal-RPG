using RealUnrealRPG.Interfaces;

namespace RealUnrealRPG.Classes
{
    internal class Player : IPlayer
    {
        //CLASS VARIABLES
        public string PlayerName = "";
        private bool KeepPlayerName = false;

        //CONSTRUCTOR
        public Player()
        {
            while (KeepPlayerName == false || PlayerName == "" || PlayerName == null || PlayerName == " ")
            {
                GetPlayerName();
                DoesUserKeepName();
            }
            Console.WriteLine($"Player name is \"{PlayerName}\"");
        }

        //CLASS METHODS

        /// <summary>
        /// Functionality to get a valid class variable PlayerName.
        /// </summary>
        public void GetPlayerName()
        {
            //Prompt a player name
            Console.WriteLine("Please, enter player name:");
            PlayerName = Console.ReadLine();

            //If player name is null or empty - player name is "Anonymous"
            if (PlayerName == null || PlayerName == "" || PlayerName == " ")
            {
                PlayerName = "Anonymous";
            }

            //Reprompt a player name whenever name starts with a digit
            while (DoesNameStartWithDigit() == true)
            {
                Console.WriteLine($"{PlayerName} is invalid player name. Name shouldn't start with a digit!");
                GetPlayerName();
                break;
            };
        }

        /// <summary>
        /// Checks if PlayerName starts with a digit.
        /// </summary>
        /// <returns>Bool: True - if starts with a digit</returns>
        private bool DoesNameStartWithDigit() 
        {
            if (char.IsDigit(PlayerName[0]) == true)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Reassign a class variable KeepPlayerName with a bool value based on user's answer input.
        /// </summary>
        private void DoesUserKeepName() 
        {

            //Propmt for user answer input
            Console.WriteLine($"Do you want to keep \"{PlayerName}\" as a player name? Y/N");
            string? userInput = Console.ReadLine();

            //Lowers an input if it is not "null"
            if (userInput != null) 
            {
                userInput = userInput.ToLower();
            }

            //Checks if user input is valid and returns a bool value based on the user's answer
            if (userInput != "y" && userInput != "n" && userInput != "yes" && userInput != "no" && userInput == null)
            {
                Console.WriteLine($"\"{userInput}\" is invalid answer");
                KeepPlayerName = false;
            }
            else if (userInput == "yes" || userInput == "y")
            {
               KeepPlayerName = true;
            }
            else if(userInput == "no" || userInput == "n")
            {
                KeepPlayerName = false;
            }
        }
    }
}