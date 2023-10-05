Question 1:
What is the value stored in the evenNumbers variable if the following LINQ query is executed on a list of integers:

var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();?

Question 2:
If you have a list of Product objects with prices [10.99, 25.49, 5.99, 15.99, 12.49], what is the total price of the most expensive product when using the following LINQ query:

var maxPrice = products.Max(p => p.Price);

Question 3:
After applying the following LINQ query on a list of strings:

var longestWords = words.OrderByDescending(w => w.Length).Take(3).ToList();

What will be the content of the longestWords list?

Question 4:
What is the value stored in the averageGrade variable if you execute the following LINQ query on a list of Student objects with grades [88, 95, 78, 90, 85]:

var averageGrade = students.Average(s => s.Grade);?

Question 5:
Given a list of Order objects with total amounts [50.25, 30.50, 75.75, 40.20, 60.30], what is the sum of the total amounts of the top 3 orders when using the following LINQ query:
var topOrders = orders.OrderByDescending(o => o.TotalAmount).Take(3).ToList();

Question 6:
If you have a list of Employee objects with salaries [50000, 60000, 55000, 70000, 48000], what is the difference between the highest and lowest salaries when using the following LINQ query:

var salaryDifference = employees.Max() - employees.Min();?

Question 7:
After applying the following LINQ query on a list of Person objects:

var distinctAges = persons.Select(p => p.Age).Distinct().ToList();

what will be the content of the distinctAges list?

Question 8:
What is the value stored in the totalLength variable if you execute the following LINQ query on a list of strings:

var totalLength = words.Sum(w => w.Length);

Question 9:
Given a list of Product objects with categories [Electronics, Clothing, Electronics, Books, Electronics], what is the count of unique categories when using the following LINQ query:

var uniqueCategories = products.Select(p => p.Category).Distinct().Count();?

Question 10:
If you have a list of Order objects with dates and total amounts, what is the total amount spent on orders placed before January 1, 2023, when using the following LINQ query:

var totalAmountBefore2023 = orders.Where(o => o.OrderDate < new DateTime(2023, 1, 1)).Sum(o => o.TotalAmount);?
