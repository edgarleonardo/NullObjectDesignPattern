using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectDesignPattern.NullObjectPattern
{
    public interface IAnimal
    {
        string AnimalName { get; set; }
        void Sound();
    }
}
