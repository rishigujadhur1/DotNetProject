using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class IfStatements
    {
        public void IfIsGreater()
        {
            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }
        }
        public void IfIsLessElse()
        {
            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            // Outputs "Good evening."
        }

        public void IfIsLessElseIf()
        {
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            // Outputs "Good evening."
        }

        // variable = (condition) ? expressionTrue :  expressionFalse;  
        public void TernaryOperator()
        {
            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);
        }
    }
}