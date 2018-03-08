using System.Collections.Generic;
using System.Linq;
using NullObjectDesignPattern.ConcreateValidImplementation;
using NullObjectDesignPattern.NullObjectPattern;

namespace NullObjectDesignPattern.Fabric
{
    public class ZooFabric
    {
        private static List<Animal> _animals;
        private static void FillList()
        {
            _animals = new List<Animal>();
            _animals.Add(new Dog("Dog"));
            _animals.Add(new Cow("Cow"));
            _animals.Add(new Cat("Cat"));
        }
        public static Animal GetAnimal(string animal)
        {
            if(_animals == null)
            {
                FillList();
            }
            var animalResult = _animals.Select(g => g).Where(a => a.AnimalName == animal);
            if (animalResult != null && animalResult.Count() > 0)
            {
                var resultInfo = animalResult.FirstOrDefault();
                if (resultInfo != null)
                {
                    return resultInfo;
                }
            }
            return Animal.NullValue;
        }
    }
}
