//Q0
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

// Creating a Class:
// A1. You can define the Person class as follows:

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
}

// Then, create an instance of the class, set its properties, and print the details:
Person person = new Person();
person.Name = "John Doe";
person.Age = 30;
person.Address = "123 Main St";

Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Address: {person.Address}");


// Class Constructors:
// A2. Modify the Person class to include constructors:

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }

    public Person()
    {
    }

    public Person(string name)
    {
        Name = name;
    }

    public Person(string name, int age, string address)
    {
        Name = name;
        Age = age;
        Address = address;
    }
}

//Create Person objects using different constructors:
Person person1 = new Person();
Person person2 = new Person("Alice");
Person person3 = new Person("Bob", 25, "456 Elm St");

// Class Methods:
// A3. Extend the Person class with a DisplayInfo method:
public class Person
{
    // Properties here...

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Address: {Address}");
    }
}

// Call the method on a Person object to display their details:
Person person = new Person();
person.Name = "Jane";
person.Age = 28;
person.Address = "789 Oak St";

person.DisplayInfo();

// Static Members:
// A4. Create a MathHelper class with a static Add method:

public class MathHelper
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

// Use this method to perform addition without creating an instance of the class:
int result = MathHelper.Add(5, 3); // Result will be 8

// Inheritance:
// A5. Define the Vehicle and Car classes with inheritance:

public class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

public class Car : Vehicle
{
    public string Color { get; set; }
    public string FuelType { get; set; }
}

// Encapsulation:
// A6. Create a BankAccount class with private fields and methods for deposit and withdrawal, ensuring that the balance is not negative:
public class BankAccount
{
    private double balance;
    private string accountNumber;

    public BankAccount(string accountNumber)
    {
        this.accountNumber = accountNumber;
        balance = 0.0;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    public bool Withdraw(double amount)
    {
        if (amount > 0 && balance >= amount)
        {
            balance -= amount;
            return true;
        }
        return false;
    }
}

// Object Initialization:
// A7. Create a Book class and initialize a list of Book objects with different book details:
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }
}

List<Book> books = new List<Book>
{
    new Book { Title = "Book1", Author = "Author1", PublicationYear = 2020 },
    new Book { Title = "Book2", Author = "Author2", PublicationYear = 2019 },
    new Book { Title = "Book3", Author = "Author3", PublicationYear = 2021 }
};

// Method Overloading:
// A8. Add overloaded constructors to the Person class to create Person objects with different parameters. For example:
public Person(string name)
{
    Name = name;
}

public Person(string name, int age) : this(name)
{
    Age = age;
}

public Person(string name, int age, string address) : this(name, age)
{
    Address = address;
}

// Access Modifiers:
// A9. Create an Employee class with private fields and use properties for read-only access:
public class Employee
{
    private int employeeId;
    private string firstName;
    private string lastName;

    public Employee(int id, string first, string last)
    {
        employeeId = id;
        firstName = first;
        lastName = last;
    }

    public int EmployeeId
    {
        get { return employeeId; }
    }

    public string FirstName
    {
        get { return firstName; }
    }

    public string LastName
    {
        get { return lastName; }
    }
}

// Class Relationships:
// A10. Define the Student and Course classes with a many-to-many relationship using appropriate data structures like lists or dictionaries. For example:
// public class Student
// {
// public int StudentId { get; set; }
// public string Name { get; set; }
// public List<Course> Courses { get; set; }
// }

public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public List<Student> Students { get; set; }
}

// Then, you can create instances of `Student` and `Course` and associate them by adding students to course lists and vice versa.
