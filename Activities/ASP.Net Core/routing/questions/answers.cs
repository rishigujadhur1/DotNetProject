// // Route Parameters:
// // 2. Answer: 
//Route parameters allow you to capture values from the URL and pass them to a controller action. For example, consider a route like "{controller}/{action}/{id}", where "id" is a route parameter. If the URL is "/products/details/123," the "id" parameter will be populated with the value "123" in the corresponding controller action.

// Route Constraints:
// 3. Answer:
// Route constraints allow you to restrict the values that a route parameter can accept. For instance, you can use a constraint like {id:int} to ensure that the "id" parameter only matches integer values. This prevents non-integer values from matching the route.

// Attribute Routing:
// 4. Answer: Attribute routing enables you to define routes directly on controller actions using attributes. For example:
[Route("products")]
public class ProductsController : Controller
{
    [Route("details/{id:int}")]
    public IActionResult ProductDetails(int id)
    {
        // Action logic for displaying product details
    }
}
// In this example, the route for the "ProductDetails" action is defined as /products/details/{id:int}, and the "id" parameter has a constraint that ensures it only matches integers.

// Named Routes:
// 5. Answer: Named routes allow you to specify a name for a route configuration, making it easier to generate URLs. You can generate URLs for named routes using the Url.Action or Url.RouteUrl methods. For example:
[Route("products", Name = "ProductRoute")]
public IActionResult Product(int id)
{
    // Action logic
}

// To generate a URL for this named route:
var url = Url.RouteUrl("ProductRoute", new { id = 123 });

