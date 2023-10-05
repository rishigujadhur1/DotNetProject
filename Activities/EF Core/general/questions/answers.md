Entity States in EF Core:
Q1. In Entity Framework Core, what are the different entity states that an entity can have? Explain each state and provide examples of how you can change an entity's state.

Tracking vs. No-Tracking:
Q2. What is the difference between tracking and no-tracking queries in EF Core? When would you use one over the other, and how do you specify the tracking behavior in a query?

Database Providers:
Q3. EF Core supports various database providers (e.g., SQL Server, SQLite, PostgreSQL). How do you specify and configure the database provider in an EF Core application? Provide an example.

Entity Framework Migrations:
Q4. What are EF Core migrations, and why are they important in database schema evolution? Explain the process of creating and applying migrations in EF Core.

EF Core Relationships:
Q5. How do you define relationships between entities in EF Core? Explain one-to-one, one-to-many, and many-to-many relationships, and provide examples.

Database Seeding:
Q6. What is database seeding in EF Core, and why is it used? Provide an example of how you can seed data into the database during application startup.

Lazy Loading vs. Eager Loading:
Q7. Compare and contrast lazy loading and eager loading in EF Core. When and why would you use one loading strategy over the other?

EF Core Transactions:
Q8. How do you work with transactions in EF Core? Explain how to begin, commit, and roll back transactions when performing multiple database operations.

EF Core Query Performance:
Q9. What are some best practices for optimizing query performance in EF Core? Explain techniques such as projection and filtering to reduce database load.

Asynchronous Operations:
Q10. Why is it beneficial to use asynchronous operations in EF Core when interacting with a database? Provide examples of how to use asynchronous methods for querying and saving data.

```services.AddDbContext<MyDbContext>(options =>
    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
```

Entity Framework Migrations:
A4. EF Core migrations are used to create, update, and manage the database schema as your application evolves. To create a new migration, you can use the dotnet ef migrations add command. To apply migrations and update the database, use dotnet ef database update. Migrations allow you to version your database schema along with your application.

EF Core Relationships:
A5. Relationships in EF Core are defined using navigation properties. For example, to create a one-to-many relationship between Author and Book entities:

```public class Author
{
    public int AuthorId { get; set; }
    public string Name { get; set; }
    public ICollection<Book> Books { get; set; }
}
public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public Author Author { get; set; }
}
```

Database Seeding:
A6. Database seeding is the process of populating the database with initial data during application startup. You can use the DbContext to insert data into the database. Example:

```if (!dbContext.Authors.Any())
{
    dbContext.Authors.Add(new Author { Name = "John Doe" });
    dbContext.SaveChanges();
}
```

Lazy Loading vs. Eager Loading:
A7. Lazy loading loads related entities from the database only when they are accessed. Eager loading loads related entities along with the main entity in a single query using the Include method. Lazy loading can result in additional database queries when accessing related data, while eager loading reduces the number of queries but may retrieve more data than needed.

EF Core Transactions:
A8. You can work with transactions in EF Core using the TransactionScope class or by explicitly starting and committing transactions through the DbContext. Example with explicit transactions:

```using var transaction = dbContext.Database.BeginTransaction();
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
```

EF Core Query Performance:
A9. To optimize query performance in EF Core, consider techniques such as:

Projection: Select only the needed columns using Select to reduce data transfer.
Filtering: Use Where to limit the data retrieved from the database.
Paging: Implement paging with Skip and Take to retrieve a subset of data.
Indexing: Create database indexes on columns frequently used in queries to improve query performance.
Asynchronous Operations:
A10. Asynchronous operations in EF Core, such as ToListAsync() and SaveChangesAsync(), allow non-blocking database operations, improving application responsiveness. For example:

```
var customers = await dbContext.Customers.ToListAsync();
await dbContext.SaveChangesAsync();
```
