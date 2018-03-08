using System;
using NullObjectDesignPattern.NullObjectPattern;

namespace NullObjectDesignPattern.ConcreateValidImplementation
{
    public class Cow : Animal
    {
        public Cow(string animalName)
        {
            this.AnimalName = animalName;
        }
        public override void Sound()
        {
            Console.WriteLine("Muuu");
        }
    }
}
