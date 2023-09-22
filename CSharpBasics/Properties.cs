using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class Properties
    {
        private string name = ""; // field

        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
    }
}

// In Program.cs
//     Properties myObj = new Properties();
//     myObj.Name = "Liam";
//     Console.WriteLine(myObj.Name);