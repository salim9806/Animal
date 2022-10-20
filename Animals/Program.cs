using Animals.AnimalModels;
using static System.Console;

namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialize all animals
            Animal[] animals = new Animal[]
            {
                new Monkey(isAlpha:false, name:"Albert", Gender.male),
                new Fish(name:"Pedro", WaterHabitat.freshWater, Gender.male),
                new Cat(name: "Bruno", isWild:false, gender:Gender.male),
                new Lion(name:"Simba", Gender.male)
            };


            //display all animals sounds            
            foreach(Animal animal in animals)
            {
                WriteLine($"{animal.Name} is a {animal.GetType().Name} and makes a sound like:\n" +
                    $"{animal.MakeSound()}\n");
            }
        }
    }
}