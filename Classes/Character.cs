using RealUnrealRPG.Interfaces;

namespace RealUnrealRPG.Classes
{
    abstract class Character : ICharacter
    {
        public Race? CharRace;
        protected List<Race> RacesList = new() { new Elf(), new Ork(), new Human(), new Dwarf()};

        public void SelectRace()
        {
            Console.WriteLine($"\nPlease, select a race for your character:\n");
            Console.WriteLine($"1. Elf\nStrength: {RacesList[0].Strength}; Accuracy: {RacesList[0].Accuracy}; Agility: {RacesList[0].Agility}; Power: {RacesList[0].Power}.\n");
            Console.WriteLine($"2. Ork\nStrength: {RacesList[1].Strength}; Accuracy: {RacesList[1].Accuracy}; Agility: {RacesList[1].Agility}; Power: {RacesList[1].Power}.\n");
            Console.WriteLine($"3. Human\nStrength: {RacesList[2].Strength}; Accuracy: {RacesList[2].Accuracy}; Agility: {RacesList[2].Agility}; Power: {RacesList[2].Power}.\n");
            Console.WriteLine($"4. Dwarf\nStrength: {RacesList[3].Strength}; Accuracy: {RacesList[3].Accuracy}; Agility: {RacesList[3].Agility}; Power: {RacesList[3].Power}.\n");
        }
    }
}
