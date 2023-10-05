// Base Class and Derived Class:
// A1. You can define the base class Animal and derived class Dog as follows:

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Dog : Animal
{
    public string Breed { get; set; }
}

Dog dog = new Dog();
dog.Name = "Buddy";
dog.Age = 3;
dog.Breed = "Golden Retriever";

// Method Overriding:
// A2. You can define and override the MakeSound method as follows:
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

Dog dog = new Dog();
dog.MakeSound(); // Output: "Dog barks"

// Abstract Base Class:
// A3. You can define an abstract base class Shape and implement derived classes like this:
public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

Circle circle = new Circle(5);
double circleArea = circle.CalculateArea();

Rectangle rectangle = new Rectangle(4, 6);
double rectangleArea = rectangle.CalculateArea();

// Constructor Inheritance:
// A4. You can create base and derived classes with constructor chaining as follows:
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

public class Employee : Person
{
    public int EmployeeId { get; set; }

    public Employee(string name, int age, int employeeId) : base(name, age)
    {
        EmployeeId = employeeId;
    }
}

// Multiple Inheritance (Interface):
// A5. You can define interfaces and a class that implements them like this:
public interface IReadable
{
    void Read();
}

public interface IWritable
{
    void Write();
}

public class File : IReadable, IWritable
{
    public void Read()
    {
        Console.WriteLine("Reading from file...");
    }

    public void Write()
    {
        Console.WriteLine("Writing to file...");
    }
}

File file = new File();
file.Read();
file.Write();

// Sealed Classes:
// A6. To mark a class as sealed, you can use the sealed keyword like this:
public sealed class Student
{
    // Class members here...
}

// A sealed class cannot be inherited from. It's used when you want to prevent further derivation of a class.

// Base Class Access:
// A7. You can access base class properties from a derived class using the base keyword:
public class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
}

public class Car : Vehicle
{
    public string Color { get; set; }

    public Car(string make, string model, string color)
    {
        Make = make;   // Accessing base class property
        Model = model; // Accessing base class property
        Color = color;
    }
}

// Method Hiding:
// A8. You can hide a base class method in a derived class using the new keyword:
public class Shape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

public class Circle : Shape
{
    public new void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

// Constructor Chaining:
// A9. Constructor chaining can be achieved using the base keyword. Here's an example:
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

public class Employee : Person
{
    public int EmployeeId { get; set; }

    public Employee(string name, int age, int employeeId) : base(name, age)
    {
        EmployeeId = employeeId;
    }
}

// Polymorphism:
// A10. Polymorphism allows you to call a method on objects of different derived classes through a common base class reference. For example:
Animal[] animals = new Animal[]
{ new Dog(), new Cat(), new Bird() };
foreach (Animal animal in animals)
{
    animal.MakeSound();
    // Calls the appropriate overridden method 
}
//In this example, the MakeSound method behaves differently depending on the actual type of the object, demonstrating polymorphism.