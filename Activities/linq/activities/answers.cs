public List<string> FilterStringsStartingWithA(List<string> inputList)
{
    return inputList.Where(s => s.StartsWith("A")).ToList();
}

// Classes used for the next LINQ tasks
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
}

public class Order
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public decimal TotalAmount { get; set; }
}

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
}

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Employee
{
    public string Name { get; set; }
    public int DepartmentId { get; set; }
}

//2 Filtering with LINQ:
var filteredList = originalList.Where(item => item.Contains("apple")).ToList();

//3 Projection with LINQ:
var projectedNames = persons.Where(p => p.Age > 30).Select(p => p.Name).ToList();

//4 Sorting with LINQ:
var sortedList = numbers.OrderBy(n => n).ToList();

//5 Grouping with LINQ:
var groupedResults = students.GroupBy(s => s.Grade)
                             .Select(g => new
                             {
                                 Grade = g.Key,
                                 AverageGrade = g.Average(s => s.Grade)
                             })
                             .ToList();

//6 Joining with LINQ:
var query = from order in orders
            join customer in customers on order.CustomerId equals customer.Id
            select new
            {
                OrderId = order.OrderId,
                CustomerName = customer.Name
            };

var result = query.ToList();

//7 Aggregate Functions with LINQ:
var sumOfEvens = numbers.Where(n => n % 2 == 0).Sum();

//8 Distinct with LINQ:
var distinctStrings = stringList.Distinct(StringComparer.OrdinalIgnoreCase).ToList();

//9 Partitioning with LINQ:
var result = numbers.Skip(3).Take(5).ToList();

//10 Nested Queries with LINQ:
var departmentWithMostEmployees = departments
    .Select(d => new
    {
        Department = d,
        EmployeeCount = employees.Count(e => e.DepartmentId == d.Id)
    })
    .OrderByDescending(dept => dept.EmployeeCount)
    .FirstOrDefault();

// Access the department with the most employees: departmentWithMostEmployees.Department

//11 Filtering with Multiple Conditions:
var filteredProducts = products.Where(p => p.Category == "Electronics" && p.Price < 500).ToList();

//12 Grouping and Aggregating with LINQ:
var customerTotalSpent = orders
    .GroupBy(o => o.CustomerId)
    .Select(group => new
    {
        CustomerId = group.Key,
        TotalAmountSpent = group.Sum(o => o.TotalAmount)
    })
    .ToList();
