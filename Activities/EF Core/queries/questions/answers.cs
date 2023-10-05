// Joining Tables with Navigation Properties:
// A1. To perform a left outer join between two tables using navigation properties, you can use the DefaultIfEmpty method to include records from the left table that have no matching records in the right table. Example:
var query = from customer in dbContext.Customers
            join order in dbContext.Orders
            on customer.CustomerId equals order.CustomerId into customerOrders
            from co in customerOrders.DefaultIfEmpty()
            select new
            {
                Customer = customer,
                Order = co
            };


// Multiple Joins and Projection:
// A2. You can perform multiple joins and projection in a single LINQ query by chaining join and Select statements. Example:
var query = from customer in dbContext.Customers
            join order in dbContext.Orders on customer.CustomerId equals order.CustomerId
            join orderDetail in dbContext.OrderDetails on order.OrderId equals orderDetail.OrderId
            select new
            {
                CustomerName = customer.Name,
                OrderId = order.OrderId,
                ProductName = orderDetail.Product.Name,
                Quantity = orderDetail.Quantity
            };

// Using GroupBy for Aggregation:
// A3. You can use the GroupBy clause to group data based on a specific property and calculate aggregate values within each group. Example:
var query = from order in dbContext.Orders
            group order by order.CustomerId into customerGroups
            select new
            {
                CustomerId = customerGroups.Key,
                TotalOrderAmount = customerGroups.Sum(o => o.TotalAmount)
            };

// Sorting Data with Multiple Columns:
// A4. To sort data based on multiple columns, you can chain the OrderBy and ThenBy methods. Example
var sortedProducts = dbContext.Products
    .OrderBy(p => p.Category)
    .ThenByDescending(p => p.Price)
    .ToList();

// Filtering Data with Complex Conditions:
// A5. You can filter data with complex conditions in EF Core using the Where clause. Example:
var filteredProducts = dbContext.Products
    .Where(p => p.Price > 100 && p.Quantity > 10)
    .ToList();

// Subqueries and Nested Queries:
// A6. Subqueries and nested queries can be achieved by nesting LINQ queries. Example of a subquery:
var query = from customer in dbContext.Customers
            where dbContext.Orders.Any(o => o.CustomerId == customer.CustomerId && o.TotalAmount > 1000)
            select customer;

// Using Any and All:
// A7. You can use the Any and All methods to check conditions within a collection. Example:
var hasHighValueOrder = dbContext.Customers
    .Any(c => c.Orders.Any(o => o.TotalAmount > 1000));

// Combining Where and Select:
// A8. You can combine the Where and Select clauses to filter and project data simultaneously. Example:
var productNamesInCategory = dbContext.Products
    .Where(p => p.Category == "Electronics")
    .Select(p => p.Name)
    .ToList();

// Limiting and Paging Results:
// A9. To limit and page results, you can use the Take and Skip methods. Example:
var firstTenProducts = dbContext.Products
    .Take(10)
    .ToList();

var secondPageOfProducts = dbContext.Products
    .Skip(10)
    .Take(10)
    .ToList();

// Using Distinct for Unique Values:
// A10. The Distinct method is used to retrieve unique values from a collection. Example:
var uniqueCategories = dbContext.Products
    .Select(p => p.Category)
    .Distinct()
    .ToList();
