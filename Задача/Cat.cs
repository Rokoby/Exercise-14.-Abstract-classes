using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача
{
    internal class Cat : Animal
    {
        public override string Name { get; set; }

        public Cat()
            :base("Кошка")
        { }

        public override string Say()
        {
            return "Мяу!";
        }
    }
}
