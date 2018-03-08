using System;
using NullObjectDesignPattern.Fabric;

namespace NullObjectDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalSearches = new string[] { "Cow", "Cat", "Dog", "Whale", "Rooster", "Chicken" };
            foreach(var animal in animalSearches)
            {
                ZooFabric.GetAnimal(animal).Sound();
            }
            Console.ReadKey();
        }
    }
}
