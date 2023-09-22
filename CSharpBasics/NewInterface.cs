using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public interface NewInterface
    {
        void animalSound(); // interface method (does not have a body)
        //void run(); // interface method (does not have a body)
    }

    public class Dog : NewInterface
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The dog says: woof woof");
        }
    }
}

// In program.cs
// Dog myDog = new Dog();  // Create a Dog object
// myDog.animalSound();