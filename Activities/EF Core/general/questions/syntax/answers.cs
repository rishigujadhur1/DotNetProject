// Entity Configuration in Fluent API:
// A1. In EF Core, you can use the Fluent API to configure entity properties and relationships in the OnModelCreating method of your DbContext class. For example, to specify the maximum length of a property and set a table name:
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Product>()
        .Property(p => p.Name)
        .HasMaxLength(50);

    modelBuilder.Entity<Product>()
        .ToTable("ProductCatalog");
}

// Query Syntax vs. Method Syntax:
// A2. In EF Core, you can write LINQ queries using both query syntax and method syntax. Query syntax uses keywords like from, where, and select, while method syntax uses extension methods like Where, Select, and OrderBy. Here's an example of a simple query using both syntaxes:
// Query Syntax
var query1 = from p in dbContext.Products
             where p.Price > 100
             select p;

// Method Syntax
var query2 = dbContext.Products
                .Where(p => p.Price > 100);

// Filtering Data with Where:
// A3. To filter data using the Where clause in EF Core, you can use the Where method in LINQ queries. Example:
var expensiveProducts = dbContext.Products
    .Where(p => p.Price > 100)
    .ToList();

// Sorting Data with OrderBy:
// A4. To sort data in ascending order, you can use the OrderBy method, and for descending order, use OrderByDescending. Example:
var sortedProducts = dbContext.Products
    .OrderBy(p => p.Price)         // Ascending
    .ThenBy(p => p.Name)           // Secondary sort
    .ToList();

// Projection with Select:
// A5. Projection in EF Core involves selecting specific columns or properties from entities. You can use the Select method for this purpose. Example:
var productNames = dbContext.Products
    .Select(p => p.Name)
    .ToList();

// Joining Tables:
// A6. To perform inner and outer joins between tables in EF Core, you can use the Join method or navigation properties. Example of an inner join:
var query = from order in dbContext.Orders
            join customer in dbContext.Customers
            on order.CustomerId equals customer.CustomerId
            select new { customer.Name, order.OrderDate };


// //Grouping and Aggregating Data:
// A7. You can use GroupBy and aggregation functions to group and summarize data in EF Core. Example:
var salesByCategory = dbContext.Products
    .GroupBy(p => p.Category)
    .Select(g => new
    {
        Category = g.Key,
        TotalSales = g.Sum(p => p.Quantity * p.Price)
    })
    .ToList();

// Including Related Data:
// A8. Eager loading in EF Core is achieved using the Include and ThenInclude methods. Example:
var orderWithDetails = dbContext.Orders
    .Include(o => o.OrderDetails)
    .ThenInclude(od => od.Product)
    .FirstOrDefault();

// Explicit Loading:
// A9. Explicit loading in EF Core involves using the Load method to load related entities on-demand. Example:
var order = dbContext.Orders.Find(1);
dbContext.Entry(order)
    .Collection(o => o.OrderDetails)
    .Load();

// Database Transactions:
// A10. To wrap database operations within a transaction in EF Core, you can use the BeginTransaction, Commit, and Rollback methods. Example:
using var transaction = dbContext.Database.BeginTransaction();
try
{
    // Perform database operations
    dbContext.SaveChanges();
    transaction.Commit();
}
catch (Exception)
{
    transaction.Rollback();
    throw;
}
