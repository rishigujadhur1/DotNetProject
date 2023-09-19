using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class Operators
    {
        public void Add()
        {
            Console.WriteLine(1 + 2);
        }
        public void Substract()
        {
            Console.WriteLine(1 - 2);
        }
        public void Multiply()
        {
            Console.WriteLine(1 * 2);
        }
        public void Divide()
        {
            Console.WriteLine(1 / 2);
        }

        public void Increment()
        {
            int i = 0;
            Console.WriteLine(i++);
        }

        public void Decrement()
        {
            int i = 0;
            Console.WriteLine(i--);
        }

        public void Modulate()
        {
            // returns reminder
            Console.WriteLine(3 % 2);
        }
    }
}