// Basic Async Method:
// A1. You can create an async method like this:
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        await DownloadFileAsync();
        Console.WriteLine("Download complete.");
    }

    static async Task DownloadFileAsync()
    {
        Console.WriteLine("Downloading file...");
        await Task.Delay(3000); // Simulate a 3-second delay
    }
}

// Async Task Return Type:
// A2. Here's an example of the CalculateSumAsync method and how to call it:
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        int result = await CalculateSumAsync(5);
        Console.WriteLine("Sum: " + result);
    }

    static async Task<int> CalculateSumAsync(int N)
    {
        int sum = 0;
        for (int i = 1; i <= N; i++)
        {
            sum += i;
            await Task.Delay(100); // Simulate some work
        }
        return sum;
    }
}

// Exception Handling with Async:
// A3. To handle exceptions in the CalculateSumAsync method:
static async Task<int> CalculateSumAsync(int N)
{
    try
    {
        int sum = 0;
        for (int i = 1; i <= N; i++)
        {
            sum += i;
            await Task.Delay(100); // Simulate some work
            if (i == 3) // Simulate an exception condition
            {
                throw new Exception("An exception occurred.");
            }
        }
        return sum;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: " + ex.Message);
        return -1; // Return a default value or error indicator
    }
}

// Async/Await in a Loop:
// A4. You can create an async method like this:
static async Task Main(string[] args)
{
    await ProcessDataAsync();
    Console.WriteLine("All items processed.");
}

static async Task ProcessDataAsync()
{
    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine($"Processing item {i}...");
        await Task.Delay(1000); // Simulate a 1-second delay
    }
}

// Async with Parallelism:
// A5. Here's an example of how to use Task.WhenAll to run tasks in parallel:
static async Task Main(string[] args)
{
    await RunTasksInParallelAsync();
    Console.WriteLine("All tasks completed.");
}

static async Task RunTasksInParallelAsync()
{
    Task task1 = Task.Run(async () =>
    {
        await Task.Delay(2000); // Simulate work
        Console.WriteLine("Task 1 completed.");
    });

    Task task2 = Task.Run(async () =>
    {
        await Task.Delay(1500); // Simulate work
        Console.WriteLine("Task 2 completed.");
    });

    Task task3 = Task.Run(async () =>
    {
        await Task.Delay(1000); // Simulate work
        Console.WriteLine("Task 3 completed.");
    });

    await Task.WhenAll(task1, task2, task3);
}

// Async Task with Cancellation Token:
// A6. You can create an async method with cancellation token support as follows:
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var cancellationTokenSource = new CancellationTokenSource();
        Task downloadTask = DownloadFileWithCancellationAsync(cancellationTokenSource.Token);

        // Simulate user interaction to cancel the download after 2 seconds
        await Task.Delay(2000);
        cancellationTokenSource.Cancel();

        try
        {
            await downloadTask;
            Console.WriteLine("Download completed.");
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Download was canceled.");
        }
    }

    static async Task DownloadFileWithCancellationAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Downloading file...");
        await Task.Delay(3000, cancellationToken); // Simulate a 3-second delay with cancellation support
    }
}

// Async and UI Threads:
// A7. Implementing an asynchronous task in a Windows Forms or WPF application involves creating an asynchronous method and using await to run it asynchronously. This keeps the UI responsive while performing a time-consuming operation. Below is a high-level example of a Windows Forms application with a progress bar:
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;

            try
            {
                await ProcessDataAsync();
                MessageBox.Show("Processing completed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            StartButton.Enabled = true;
        }

        private async Task ProcessDataAsync()
        {
            for (int i = 1; i <= 5; i++)
            {
                // Simulate a time-consuming task
                await Task.Delay(1000);
                UpdateProgressBar(i * 20); // Update progress bar
            }
        }

        private void UpdateProgressBar(int value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => progressBar.Value = value));
            }
            else
            {
                progressBar.Value = value;
            }
        }
    }
}

// Async/Await with File I/O:
// A8. Reading a large file asynchronously using StreamReader can be done as follows:
using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        await ReadFileAsync("largefile.txt");
        Console.WriteLine("File reading completed.");
    }

    static async Task ReadFileAsync(string filePath)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            char[] buffer = new char[1024];
            while (!reader.EndOfStream)
            {
                int bytesRead = await reader.ReadAsync(buffer, 0, buffer.Length);
                // Process the read data here
            }
        }
    }
}

// Async and Database Operations:
// A9. Performing database operations asynchronously typically involves using an ORM like Entity Framework (EF). Here's an example of reading data from a database table asynchronously:
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        using (var dbContext = new MyDbContext())
        {
            List<Employee> employees = await dbContext.Employees.ToListAsync();
            foreach (var employee in employees)
            {
                Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}");
            }
        }
    }
}

public class MyDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
}

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}

// Async in Web API:
// A10. Creating an ASP.NET Web API with an asynchronous endpoint can be done like this:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

public class ValuesController : ApiController
{
    [HttpGet]
    [Route("api/values")]
    public async Task<IHttpActionResult> GetValuesAsync()
    {
        try
        {
            // Simulate asynchronous database or service call
            List<string> values = await FetchDataFromDatabaseAsync();
            return Ok(values);
        }
        catch (Exception ex)
        {
            return InternalServerError(ex);
        }
    }

    private async Task<List<string>> FetchDataFromDatabaseAsync()
    {
        await Task.Delay(2000); // Simulate async operation
        return new List<string> { "Value1", "Value2", "Value3" };
    }
}

// In this example, the GetValuesAsync method simulates an asynchronous database call and returns data when ready.