using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class stringMethods
    {
        public void Cap()
        {
            string txt = "Hello World";
            Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
        }

        public void RemoveCap()
        {
            string txt = "Hello World";
            Console.WriteLine(txt.ToLower());   // Outputs "hello world"
        }

        public void fullName()
        {
            string firstName = "John ";
            string lastName = "Doe";
            string name = string.Concat(firstName, lastName);
            Console.WriteLine(name);
        }

        public void Interpolate()
        {
            string firstName = "John";
            string lastName = "Doe";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);
        }

        public void StringAccess()
        {
            string myString = "Hello";
            Console.WriteLine(myString[0]);  // Outputs "H"
        }

        public void StringIndex()
        {
            string myString = "Hello";
            Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"
        }


    }
}