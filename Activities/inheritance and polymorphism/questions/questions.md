Base Class and Derived Class:
Q1. Define a base class called Animal with properties like Name and Age. Create a derived class called Dog that inherits from Animal and includes additional properties like Breed. Create an instance of Dog and set its properties.

Method Overriding:
Q2. Extend the Animal and Dog classes from the previous question. Add a method called MakeSound in the Animal class and override it in the Dog class to make the dog bark. Call this method on a Dog object.

Abstract Base Class:
Q3. Define an abstract base class called Shape with an abstract method CalculateArea(). Create derived classes Circle and Rectangle that implement this method to calculate the area of a circle and rectangle, respectively. Create instances of these classes and calculate their areas.

Constructor Inheritance:
Q4. Create a base class Person with properties for Name and Age. Add a constructor to initialize these properties. Create a derived class Employee that includes additional properties like EmployeeId and a constructor to initialize them. How can you ensure that the base class constructor is called when creating an Employee object?

Multiple Inheritance (Interface):
Q5. Define an interface IReadable with a method Read() and another interface IWritable with a method Write(). Create a class File that implements both interfaces and provides implementations for Read and Write. Create an instance of File and call its Read and Write methods.

Sealed Classes:
Q6. Create a class called Student. Extend this class with a derived class called GraduateStudent. Mark the Student class as sealed. Why would you use the sealed keyword, and what is its significance?

Base Class Access:
Q7. Create a base class Vehicle with properties like Make and Model. Define a derived class Car that includes additional properties like Color. Can you access the properties of the base class from an instance of the derived class? How?

Method Hiding:
Q8. Create a base class Shape with a method Draw. Create a derived class Circle and also define a method called Draw. How can you hide the base class method while defining a new one in the derived class?

Constructor Chaining:
Q9. Create a base class Person with a parameterized constructor. Create a derived class Employee that calls the base class constructor using base() and also has its own constructor. How does constructor chaining work in this scenario?

Polymorphism:
Q10. Create a base class Animal with a method MakeSound. Create derived classes Dog, Cat, and Bird that override this method to make appropriate sounds. Create an array of Animal objects and call the MakeSound method on each. How does polymorphism come into play?
