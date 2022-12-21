using RealUnrealRPG.Interfaces;

namespace RealUnrealRPG.Classes
{
    abstract class Character : ICharacter
    {
        protected List<Race> RacesList = new() { new Elf(), new Ork(), new Human(), new Dwarf()};

        public void SelectRace()
        {
            byte counter = 1;
            Console.WriteLine($"\nPlease, select a race for your character:\n");
            RacesList.ForEach((race) => {
                Console.WriteLine($"{counter}. {race.Name}\nStrength: {race.Strength}; Accuracy: {race.Accuracy}; Agility: {race.Agility}; Power: {race.Power}.\n");
                counter += 1;
            });
        }
    }
}
