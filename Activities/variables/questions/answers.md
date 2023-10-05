Variable Declaration:
A1. Variable declaration in C# involves specifying the data type and an optional name for a variable. The syntax varies based on the data type:

For integers: int number;
For strings: string text;
For floating-point numbers: double price;
For booleans: bool isTrue;
Variable Initialization:
A2. Variable initialization is the process of assigning an initial value to a variable. It is important to ensure that variables have meaningful values before using them. Examples:

```
int age = 25;       // Initializing at declaration
string name;        // Declaration without initialization
name = "John";      // Initializing later

```

Default Values:
A4. Variables in C# are automatically assigned default values when declared but not explicitly initialized. Common default values include:

0 for numeric types (e.g., int, float).
false for booleans (e.g., bool).
null for reference types (e.g., string, objects).
Constant Variables:
A5. Constant variables in C# are declared using the const keyword and must be initialized at the point of declaration. They cannot be changed after initialization. Example:

```
const double Pi = 3.14159;

```

Scope and Lifetime:
A6.

The scope of a variable defines where in the code the variable can be accessed. Local variables have method-level scope, instance variables belong to an instance of a class, and static variables have class-level scope.
The lifetime of a variable is the duration for which it exists in memory. Local variables have a shorter lifetime (limited to the method they are declared in), while instance and static variables can live throughout the program's execution.
Variable Naming Conventions:
A7. Variable naming conventions in C# typically follow these guidelines:

Use meaningful names that describe the variable's purpose.
Use camelCase for local and private variables (e.g., userName).
Use PascalCase for public and internal variables (e.g., FirstName).
Avoid using reserved keywords as variable names.
Variable Shadowing:
A8. Variable shadowing occurs when a variable in a narrower scope (e.g., a method) has the same name as a variable in a wider scope (e.g., a class-level variable). It can make code less readable and may lead to unexpected behavior.

Read-Only Variables:
A9. Read-only variables in C# are declared using the readonly keyword and can only be assigned a value once, either at declaration or in a constructor. They provide a way to create constants that are determined at runtime. Example:

```
readonly int maxAttempts = 3;

```

Variable Interpolation:
A10. Variable interpolation in C# allows you to embed variable values directly within string literals using the $ character followed by curly braces {}. It simplifies string concatenation and formatting. Example:

```
int age = 30;
string message = $"My age is {age} years.";
```
