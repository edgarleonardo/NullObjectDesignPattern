using System;
using NullObjectDesignPattern.NullObjectPattern;

namespace NullObjectDesignPattern.ConcreateValidImplementation
{
     public class Cat : Animal
    {
        public Cat(string animalName)
        {
            this.AnimalName = animalName;
        }
        public override void Sound()
        {
            Console.WriteLine("Miau");
        }
    }
}
