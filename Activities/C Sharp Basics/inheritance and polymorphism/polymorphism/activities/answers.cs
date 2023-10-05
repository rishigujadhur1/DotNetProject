// Polymorphic Behavior:
// A2. Polymorphism allows you to call a method on objects of different derived classes through a common base class reference. For example:

Shape[] shapes = new Shape[] { new Circle(), new Rectangle() };
foreach (Shape shape in shapes)
{
    shape.Draw(); // Calls the appropriate overridden Draw method
}

// In this example, the Draw method is called on objects of the Circle and Rectangle classes through a base class reference, demonstrating polymorphic behavior.

// Abstract Classes and Polymorphism:
// A3. Abstract classes can be used to achieve polymorphism by providing a common base for derived classes to implement. An abstract class can include abstract methods that must be implemented by derived classes, enabling polymorphic behavior when objects of derived classes are used through a base class reference. Example:
public abstract class Shape
{
    public abstract void Draw();
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

// Interface Polymorphism:
// A4. Interfaces enable polymorphism by defining a contract that classes can implement. Multiple classes can implement the same interface, allowing polymorphic behavior when objects of these classes are accessed through the interface type. Example:
public interface IPlayable
{
    void Play();
}

public class MusicPlayer : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Playing music");
    }
}

public class VideoPlayer : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Playing video");
    }
}

// You can call the Play method on objects of both MusicPlayer and VideoPlayer through an IPlayable reference.

// Polymorphism in Collections:
// A5. Polymorphism allows you to work with objects of derived classes in a collection of a base class type. Example:
List<Shape> shapes = new List<Shape> { new Circle(), new Rectangle() };
foreach (Shape shape in shapes)
{
    shape.Draw(); // Calls the appropriate overridden Draw method
}

// In this example, objects of Circle and Rectangle classes are stored in a list of Shape, and polymorphism enables calling the Draw method on each object.

// Sealed Methods and Polymorphism:
// A6. When a method in a derived class is marked as sealed, it cannot be further overridden in any derived class. This restricts polymorphism because it prevents any additional specialization of the method in further derived classes.

// Dynamic Polymorphism vs. Static Polymorphism:
// A7.
// Dynamic Polymorphism: Also known as runtime polymorphism, dynamic polymorphism is resolved at runtime. It allows you to call overridden methods on objects of derived classes through a base class reference. It is achieved through inheritance and method overriding.
// Static Polymorphism: Also known as compile-time polymorphism, static polymorphism is resolved at compile time. It involves method overloading, where the appropriate method to call is determined based on the method signature (number and types of parameters) at compile time.

// Polymorphism in Method Parameters:
// A8. Polymorphism in method parameters allows you to pass objects of derived classes as arguments to methods that accept base class parameters. Example:
public void DisplayShapeInfo(Shape shape)
{
    shape.Draw(); // Calls the appropriate overridden Draw method
}

// Usage
DisplayShapeInfo(new Circle());
DisplayShapeInfo(new Rectangle());

// Polymorphism and Method Resolution:
// A9. Method resolution in polymorphism is performed by the .NET runtime using method tables and virtual method tables (vtables). When you call a method on an object through a base class reference, the runtime determines the actual type of the object and invokes the appropriate overridden method. This allows for dynamic dispatch and runtime method resolution.

// Interface Inheritance and Polymorphism:
// A10.Interface inheritance allows a class to implement multiple interfaces, which enables polymorphism by allowing objects of that class to be used interchangeably based on the interfaces they implement. Example:public interface IDrawable
public interface IDrawable
{
    void Draw();
}

public interface IResizable
{
    void Resize();
}

public class Shape : IDrawable, IResizable
{
    public void Draw()
    {
        Console.WriteLine("Drawing the shape");
    }

    public void Resize()
    {
        Console.WriteLine("Resizing the shape");
    }
}

// Usage
IDrawable drawableShape = new Shape();
IResizable resizableShape = new Shape();
drawableShape.Draw();
resizableShape.Resize();

// In this example, objects of the Shape class can be used through interfaces IDrawable and IResizable, enabling polymorphic behavior based on the interfaces.