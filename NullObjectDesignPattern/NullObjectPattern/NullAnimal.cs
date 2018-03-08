using System;

namespace NullObjectDesignPattern.NullObjectPattern
{
    internal class NullAnimal : Animal
    {
        public override void Sound()
        {
            Console.WriteLine($"This Animal Doen't Exists At The Zoo");
        }
    }
}
