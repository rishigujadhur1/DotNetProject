using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class DataTypes
    {
        int myNum = 5;               // Integer (whole number)
        double myDoubleNum = 5.99D;  // Floating point number
        char myLetter = 'D';         // Character
        bool myBool = true;          // Boolean
        string myText = "Hello";     // String

        public void DisplayValue()
        {
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);
        }
    }
}