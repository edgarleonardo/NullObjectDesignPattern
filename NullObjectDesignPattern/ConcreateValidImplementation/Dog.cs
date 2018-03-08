using System;
using NullObjectDesignPattern.NullObjectPattern;

namespace NullObjectDesignPattern.ConcreateValidImplementation
{
    public class Dog : Animal
    {
        public Dog(string animalName)
        {
            this.AnimalName = animalName;
        }
        public override void Sound()
        {
            Console.WriteLine("Jaw");
        }
    }
}
