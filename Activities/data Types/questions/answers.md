Data Types Questions:

Primitive Data Types:
A1. Primitive data types in C# are basic data types that represent fundamental values. Examples include:

Integer types: int, long, short, byte
Floating-point types: float, double, decimal
Character type: char
Boolean type: bool
Data Type Conversion:
A2.

Implicit type conversion (also known as widening or automatic casting) occurs when a smaller data type is automatically promoted to a larger data type. It's done without loss of data. Example: int to double.

Explicit type conversion (also known as narrowing or casting) requires a cast operator and is used when converting from a larger data type to a smaller one, potentially resulting in data loss. Example: double to int.

Value Types vs. Reference Types:
A3.

Value types store their data directly in memory, and variables of value types contain the actual data. Examples include integers (int), floating-point numbers (double), and structs.

Reference types store a reference (memory address) to the actual data, which is stored on the heap. Examples include classes, strings, and arrays. Variables of reference types hold references to data.

Nullable Value Types:
A4. Nullable value types, represented by types like int? or double?, allow value types to have a null value in addition to their regular values. They are useful when you need to represent missing or undefined data in a value type.

String Data Type:
A5. The string data type in C# represents sequences of characters. It is a reference type and supports various string manipulation methods. Examples:

```
string firstName = "John";
string lastName = "Doe";
string fullName = $"{firstName} {lastName}"; // String interpolation
```

Arrays and Collections:
A6. Arrays are fixed-size collections of elements with the same data type. Lists (e.g., List<T>) are dynamic collections that can grow or shrink. Lists are often preferred when the size is unknown or needs to change dynamically.

Enum Data Type:
A7. An enum (enumeration) data type in C# is a set of named constant values. Enums provide more readability and type safety compared to using integer constants. Example:

```
enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
Days today = Days.Wednesday;

```

DateTime Data Type:
A8. The DateTime data type in C# is used for representing dates and times. You can create, format, and parse DateTime objects. Example:

```
DateTime now = DateTime.Now;
string formattedDate = now.ToString("yyyy-MM-dd HH:mm:ss");
DateTime parsedDate = DateTime.Parse("2023-10-04");

```

Structures vs. Classes:
A9. Structures (structs) are value types and are typically used for small, simple data structures. They are suitable for cases where you want value semantics and don't require inheritance or reference types.

Type Inference:
A10. Type inference in C# allows the compiler to deduce the type of a variable based on its initialization. The var keyword is used for type inference. Example:

```
var name = "Alice"; // Compiler infers 'name' as string
var number = 42;    // Compiler infers 'number' as int

```
