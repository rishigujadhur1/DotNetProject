What is the Purpose of GroupBy for Aggregation in EF Core?
Q1. Explain the purpose and significance of using the GroupBy clause for aggregation in Entity Framework Core. How does it differ from non-grouped aggregations?

Basic Usage of GroupBy and Aggregation:
Q2. How can you use the GroupBy clause in EF Core to group data by a specific property and perform basic aggregations, such as sum, average, or count? Provide an example.

Using Multiple Aggregation Functions with GroupBy:
Q3. Describe how you can apply multiple aggregation functions (e.g., sum and average) to grouped data using the GroupBy clause in EF Core. Provide an example that calculates both the total and average order amounts for each customer.

Grouping by Multiple Columns:
Q4. How can you use the GroupBy clause to group data by multiple columns (composite grouping) in EF Core? Provide an example that groups orders by both customer and order date.

Applying Having Clause for Group Filters:
Q5. Explain the purpose of the Having clause in EF Core's GroupBy queries. How can you use it to filter groups based on aggregation results? Provide an example.

Combining GroupBy with Joins:
Q6. Describe scenarios where you might need to combine the GroupBy clause with joins in EF Core queries. Provide an example that demonstrates the use of GroupBy along with a join to retrieve aggregated data.

Grouping by Date Intervals:
Q7. How can you use the GroupBy clause in EF Core to group data by date intervals (e.g., monthly or yearly) when dealing with temporal data? Provide an example of grouping orders by month.

Handling Null Values in Aggregation:
Q8. Explain how Entity Framework Core handles null values when performing aggregation functions within a GroupBy query. What should you be aware of when working with nullable columns?

Using CountDistinct for Unique Counts:
Q9. In EF Core, how can you calculate the count of distinct values within a group when using the GroupBy clause? Provide an example of counting distinct products purchased by each customer.

Performance Considerations with GroupBy Aggregations:
Q10. What are some performance considerations when using the GroupBy clause for aggregations in EF Core, especially when dealing with large datasets? How can you optimize the performance of such queries?
