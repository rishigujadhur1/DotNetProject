using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class ClassContructor
    {
        public string model;

        // Create a class constructor with a parameter
        public ClassContructor(string modelName)
        {
            model = modelName;
        }
    }
}

//     In Program.cs 
//     ClassContructor Ford = new ClassContructor("Mustang");
//     Console.WriteLine(Ford.model);
