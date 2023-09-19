using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class ClassMembers
    {
        // Class members
        string color = "red";        // field
        int maxSpeed = 200;          // field
        public void fullThrottle()   // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }
}