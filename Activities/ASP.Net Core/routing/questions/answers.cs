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

// Route Tokens and Template Segments:
// 5. Answer: In route templates, route tokens are placeholders enclosed in curly braces (e.g., {controller}). Template segments are the parts of the route template between slashes (e.g., "/{controller}/{action}"). Tokens represent route parameters, while segments are static parts of the URL.

// Default Routes:
// 7. Answer: Route parameters with constraints are defined by including a constraint in the route template. For example, {id:int} is a constraint that ensures the "id" parameter only matches integer values.

// Route Prefixes:
// 8. Answer: Route prefixes are used to group related routes together under a common URL segment. For example, you can use [RoutePrefix("products")] on a controller to group all its actions under the "/products" URL prefix.

// Fallback Routes:
// 10 Answer: Areas in ASP.NET Core allow you to organize your application into modular sections. You can define routes specific to an area by including the area name in the route configuration. For example, [Area("Admin")] is used to specify an area for a controller.
