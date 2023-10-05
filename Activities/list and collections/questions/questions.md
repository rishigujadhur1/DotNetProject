List Question 1:
What is the value stored in the evenNumbers list
if you execute the following code:

var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

where numbers is a list of integers [1, 2, 3, 4, 5, 6]?

List Question 2:

If you have a list of strings fruits with values [apple, banana, cherry, date, grape], what will be the content of the shortFruits list after executing the following code:

var shortFruits = fruits.Where(f => f.Length < 6).ToList();

Dictionary Question 1:
Given a dictionary studentGrades where keys are student names and values are their grades:

var studentGrades = new Dictionary<string, int>
{
{"Alice", 92},
{"Bob", 78},
{"Carol", 85},
{"Dave", 90}
};

What is the grade of the student named "Bob" when you access it using studentGrades["Bob"]?

Dictionary Question 2:
If you have a dictionary employeeSalaries where keys are employee IDs (integers) and values are their salaries (decimals):

var employeeSalaries = new Dictionary<int, decimal>
{
{101, 55000.50m},
{102, 60000.75m},
{103, 48000.25m},
{104, 70000.00m}
};

What is the salary of the employee with ID 103 when you access it using employeeSalaries[103]?

HashSet Question 1:
Given a HashSet<int> called uniqueNumbers containing unique integers, what happens when you attempt to add a duplicate number to the set using uniqueNumbers.Add(5)?

HashSet Question 2:
If you have a HashSet<string> called colors containing colors "red", "green", and "blue", what is the result of the following code:

var containsYellow = colors.Contains("yellow");

Queue Question 1:
Create a Queue<string> called customerQueue and perform the following operations:

Enqueue the names of three customers: "Alice", "Bob", and "Carol".
Dequeue the first customer from the queue. What is their name?

Queue Question 2:
If you have a Queue<int> called numberQueue with values [1, 2, 3, 4, 5], what is the result of the following code:

var frontNumber = numberQueue.Peek();
