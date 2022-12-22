using RealUnrealRPG.Interfaces;

namespace RealUnrealRPG.Classes
{
    internal class Character : Race, ICharacter
    {
        //CLASS VARIABLES
        public Race? race;
        protected List<Race> RacesList = new() { new Elf(), new Ork(), new Human(), new Dwarf()};

        //METHODS
        //Functionality of character race selection.
        public void SelectRace()
        {
            //Print a possible choice of a character race to the console.
            short counter = 1;
            Console.WriteLine($"\nPlease, select a race for your character:\n");
            RacesList.ForEach((race) => {
                Console.WriteLine($"{counter}. {race.Name}\nStrength: {race.Strength}; Accuracy: {race.Accuracy}; Agility: {race.Agility}; Power: {race.Power}.\n");
                counter += 1;
            });

            //Assign a race type to the character based on user's selection.
            string? userInput = Console.ReadLine();
            if (userInput != null)
            {
                int intUserInput = GetIntOfInput(userInput);
                if (intUserInput != 0 && intUserInput <= RacesList.Count())
                {
                    race = RacesList[intUserInput - 1];
                }
                else
                {
                    Console.WriteLine("Selection is not valid");
                    SelectRace();
                }
            }
            else
            {
                Console.WriteLine("Please, make a selection!\n");
                SelectRace();
            }
        }

        //Tries to parse index 0 char of input to short - returns it if parsed seccussesfuly, otherwise returns null.
        private static int GetIntOfInput(string input)
        {
            char zeroIndexChar = input[0];
            string element = zeroIndexChar.ToString();
            int.TryParse(element, out int result);
            return result;
        }
    }
}
