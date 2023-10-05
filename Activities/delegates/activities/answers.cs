// 0
public class Publisher
{
    public event EventHandler MyEvent;

    public void RaiseEvent()
    {
        MyEvent?.Invoke(this, EventArgs.Empty);
    }
}

public class Subscriber
{
    public void Subscribe(Publisher publisher)
    {
        publisher.MyEvent += HandleEvent;
    }

    public void HandleEvent(object sender, EventArgs e)
    {
        Console.WriteLine("Event handled by subscriber.");
    }
}

// Usage
var publisher = new Publisher();
var subscriber = new Subscriber();
subscriber.Subscribe(publisher);
publisher.RaiseEvent(); // This will trigger the event.


// 1
// Delegate Basics:

// Delegate Definition:
// A1. A delegate in C# is a type that represents references to methods with a specific signature. It allows you to treat methods as first-class objects, enabling you to pass methods as arguments to other methods, return methods from methods, and store methods in data structures. Delegates are often used for implementing event handling, callbacks, and creating extensible and flexible code.

// Delegate Declaration:
// A2. To declare a delegate in C#, you use the delegate keyword followed by the return type and parameters of the method signature that the delegate will represent. Here's an example:
delegate int MathOperation(int x, int y);

// 2
// Delegate Usage:

// Delegate Instantiation:
// A3. To instantiate a delegate, you create an instance of the delegate type and associate it with a method that matches the delegate's signature. Here's an example:

MathOperation add = (a, b) => a + b;

// Delegate Invocation:
// A4. You can invoke (call) a delegate by using its name followed by parentheses, passing the required arguments. Here's an example:
int result = add(3, 5); // result will be 8

// Multicast Delegates:
// A5. Multicast delegates are delegates that can hold references to multiple methods. You can combine multiple delegates using the += operator and invoke them all with a single call. Here's an example:
MathOperation add = (a, b) => a + b;
MathOperation subtract = (a, b) => a - b;
MathOperation multiDelegate = add + subtract;
int result = multiDelegate(8, 4); // result will be 12 (add) and 4 (subtract)
