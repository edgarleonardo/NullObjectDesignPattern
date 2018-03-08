
using System;

namespace NullObjectDesignPattern.NullObjectPattern
{
    public abstract class Animal : IAnimal
    {
        public static readonly Animal NullValue = new NullAnimal();

        public string AnimalName
        {
            get;
            set;
        }

        public abstract void Sound();
    }
}
