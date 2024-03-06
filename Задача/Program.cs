using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine(dog.Say());
            dog.ShowInfo();

            Cat cat = new Cat();
            Console.WriteLine(cat.Say());
            cat.ShowInfo();
            Console.ReadKey();
        }
    }
}
