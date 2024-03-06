using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача
{
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public Animal(string name) 
        {
            Name = name;
        }

        public abstract string Say();

        public void ShowInfo()
        {
            Console.WriteLine($"{Name} говорит {Say()}");
        }
    }
}
