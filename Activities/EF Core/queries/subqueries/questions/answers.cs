// What is a Subquery in EF Core?
// A1. A subquery in Entity Framework Core is a query that is embedded within another query. It is used to retrieve data based on the results of an inner query. Subqueries are enclosed within parentheses and can be used in various parts of a query, such as the Where, Select, or From clauses.

// Using Any for Subqueries:
// A2.The Any method in EF Core is used to perform a subquery that checks if a certain condition is met within a related collection. For example, to find customers who have placed at least one order, you can use the Any method:
var query = from customer in dbContext.Customers
            where customer.Orders.Any()
            select customer;

// Using All for Subqueries:
// A3. The All method in EF Core is used to perform a subquery that verifies if all elements in a related collection meet a specific condition. For example, to find products that have been reviewed positively by all customers:

var query = from product in dbContext.Products
            where dbContext.Customers.All(c => c.Reviews.Any(r => r.ProductId == product.ProductId && r.Rating >= 4))
            select product;

// Nested Subqueries:
// A4. A nested subquery in EF Core is a subquery that is embedded within another subquery or a main query. This allows you to perform complex queries involving multiple levels of subqueries. For example, a query that retrieves products based on the average rating of their reviews:

var query = from product in dbContext.Products
            where dbContext.Reviews
                .Where(r => r.ProductId == product.ProductId)
                .Average(r => r.Rating) >= 4.5
            select product;

// Subqueries with Aggregation:
// A5. Subqueries in EF Core can be used to perform aggregations or calculations on related data before including it in the main query's results. For example, to find customers with the highest total order amount:

var query = from customer in dbContext.Customers
            where customer.Orders.Sum(o => o.TotalAmount) ==
                  dbContext.Customers.Max(c => c.Orders.Sum(o => o.TotalAmount))
            select customer;

// Performance Considerations for Subqueries:
// A6. When using subqueries in EF Core, it's important to consider performance. Subqueries can lead to additional database queries, so optimizing database indexes, using Include or ThenInclude to reduce the number of queries, and using appropriate filtering can help improve performance.

// Combining Subqueries and Joins:
// A7. You can combine subqueries and joins in EF Core to retrieve data from multiple related tables while also performing subquery operations. For example, to find customers who have placed orders for specific products:
var query = from customer in dbContext.Customers
            join order in dbContext.Orders on customer.CustomerId equals order.CustomerId
            where dbContext.Products.Any(p => p.ProductId == order.ProductId && p.Category == "Electronics")
            select customer;

// Subqueries with Where Conditions:
// A8. Subqueries with Where conditions in EF Core allow you to filter the results of the main query based on the results of the subquery. For example, to retrieve products that have been reviewed by customers from a specific country:
var query = from product in dbContext.Products
            where dbContext.Reviews.Any(r => r.ProductId == product.ProductId && r.Customer.Country == "USA")
            select product;

// Subqueries for Existence Checks:
// A9. Subqueries can be used for existence checks in EF Core. For example, to find customers who have not placed any orders, you can use the Any method with a negation:
var query = from customer in dbContext.Customers
            where !customer.Orders.Any()
            select customer;

// Subqueries with Projections:
// A10. Subqueries in EF Core can also be used for projections. For example, to retrieve a list of customers along with their most recent order details:
var query = from customer in dbContext.Customers
            select new
            {
                CustomerName = customer.Name,
                MostRecentOrder = dbContext.Orders
                    .Where(o => o.CustomerId == customer.CustomerId)
                    .OrderByDescending(o => o.OrderDate)
                    .FirstOrDefault()
            };
