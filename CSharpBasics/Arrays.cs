using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class Arrays
    {
        public void DisplayArray()
        {
            int[] myNum = { 10, 20, 30, 40 };
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(myNum[3] + cars[0]);
            cars[0] = "Subaru";
            Console.WriteLine(myNum[3] + cars[0]);
            Console.WriteLine(cars.Length);
        }

        public void LoopArrayForloop()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }

        public void LoopArrayForeachloop()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }

        public void SortArray()
        {
            // Sort an int
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }
        }

    }
}