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