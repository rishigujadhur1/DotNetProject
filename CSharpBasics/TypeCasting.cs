using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class TypeCasting
    {
        public void TypeCast()
        {
            double myDouble = 9.78;
            int myInt = (int)myDouble;    // Manual casting: double to int 
            Console.WriteLine(myDouble);   // Outputs 9.78
            Console.WriteLine(myInt);      // Outputs 9
            Console.ReadLine();
        }

    }
}