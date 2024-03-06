using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача
{
    internal class Dog : Animal
    {
        public override string Name { get; set; }

        public Dog()
            : base("Собака")
        { }

        public override string Say()
        {
            return "Гав!";
        }
    }
}
