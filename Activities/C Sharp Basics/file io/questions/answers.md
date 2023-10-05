File I/O Questions:

Reading from a File:
A1. To read the contents of a text file in C#, you can use the System.IO.File class or System.IO.StreamReader. Here's an example using StreamReader to read a text file line by line:

```
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt";
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}

```

Writing to a File:
A2. You can write text to a new or existing file in C# using System.IO.File class or System.IO.StreamWriter. Here's an example using StreamWriter to write text to a file:

```
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "output.txt";
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Hello, World!");
        }
    }
}
```

File Access Modes:
A3. The common file access modes in C# are:

FileMode.Create: Creates a new file or overwrites an existing one.
FileMode.Append: Appends data to an existing file or creates a new one if it doesn't exist.
FileMode.Open: Opens an existing file for reading.
FileMode.OpenOrCreate: Opens an existing file for reading or creates a new file if it doesn't exist.
FileMode.Truncate: Opens an existing file for writing and truncates its contents.

Handling File Exceptions:
A4. Common file-related exceptions in C# include IOException, UnauthorizedAccessException, and FileNotFoundException. To handle these exceptions, you can use try-catch blocks to gracefully handle errors, log exceptions, or provide user-friendly error messages.

File Paths and Directories:
A5. File paths in C# can be specified as absolute (e.g., "C:\folder\file.txt") or relative to the current working directory (e.g., "file.txt"). Absolute paths specify the full path from the root, while relative paths are relative to the current directory. You can use Path.Combine to create platform-independent paths.

Binary File I/O:
A6. Binary file I/O involves reading and writing raw binary data to files. Unlike text files, binary files are not human-readable. You can use System.IO.BinaryReader and System.IO.BinaryWriter to read and write binary data to files. Example:

```
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "data.dat";
        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
        {
            writer.Write(42);
        }
        using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
        {
            int value = reader.ReadInt32();
            Console.WriteLine("Read value: " + value);
        }
    }
}

```

File Stream:
A7. A file stream in C# represents a sequence of bytes that you can read from or write to a file. You can use System.IO.FileStream to work with file streams. It allows low-level access to files, making it useful for binary file I/O.

Working with Directories:
A8. You can create, delete, or manipulate directories in C# using methods from the System.IO.Directory class. For example, you can use Directory.CreateDirectory(path) to create a directory and Directory.Delete(path) to delete it.

File Serialization:
A9. Object serialization in C# allows you to convert objects into a format that can be easily saved to a file and later deserialized to recreate the original objects. You can use libraries like System.Runtime.Serialization to perform serialization and deserialization. Example:

```
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class Person
{
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        string filePath = "person.dat";

        // Serialization
        Person person = new Person { Name = "Alice" };
        IFormatter formatter = new BinaryFormatter();
        using (FileStream stream = new FileStream(filePath, FileMode.Create))
        {
            formatter.Serialize(stream, person);
        }

        // Deserialization
        using (FileStream stream = new FileStream(filePath, FileMode.Open))
        {
            Person deserializedPerson = (Person)formatter.Deserialize(stream);
            Console.WriteLine("Deserialized Name: " + deserializedPerson.Name);
        }
    }
}

```

FileWatcher:
A10. The FileSystemWatcher class in C# allows you to monitor changes to files and directories. You can subscribe to events like Created, Changed, Deleted, and Renamed to track changes. It is commonly used for tasks like monitoring log files or directories for new files.
