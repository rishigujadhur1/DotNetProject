// Routing in ASP.NET Core:

// Answer 1: In ASP.NET Core MVC, you can define custom route templates using the [Route] attribute on controller actions. Here's an example:
[Route("products/{id}")]
public IActionResult ProductDetails(int id)
{
    // Controller action logic
}

// Razor Pages Syntax:
// Answer: In Razor Pages, you can define a page model property using the @page directive in the .cshtml.cs file and display its value in the Razor view using @Model.PropertyName. Example:
// Razor Page Model (.cshtml.cs):

public class IndexModel : PageModel
{
    public string Message { get; set; } = "Hello, World!";

    public void OnGet()
    {
    }
}

// Razor Page View (.cshtml):
< p > @Model.Message </ p >


// View Component Syntax:
// Answer 2: To create a custom view component in ASP.NET Core, you define a class that inherits from ViewComponent and create a method with the name InvokeAsync or Invoke to perform the view component's logic. Here's an example:
// View Component Class:

public class MyViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        // View component logic
        return View();
    }
}

// Invoking the View Component in a Razor View:
@await Component.InvokeAsync("MyViewComponent")

// Action Filters in Controller Methods:
// Answer 3: To apply an action filter attribute to a controller action method, you can use the [FilterName] attribute or one of the built-in action filter attributes like [Authorize]. Example:
// Applying [Authorize] Attribute:
[Authorize]
public IActionResult SecureAction()
{
    // Action logic for authorized users
}

// Authentication and Authorization Attributes:
// Answer 4: Authentication and authorization attributes are applied to controller actions using [Authorize] and [AllowAnonymous]. Example:
// Applying [Authorize] Attribute:
[Authorize(Roles = "Admin")]
public IActionResult AdminAction()
{
    // Action logic for authenticated users with "Admin" role
}

// Model Binding Syntax:
// Answer 5: To perform model binding in ASP.NET Core, you can receive a model object as a parameter in a controller action method. Example:
// Model Binding in a Controller Action:
public IActionResult ProcessForm([FromBody] MyModel model)
{
    // Access model properties
}

// View Component Tag Helper Syntax:
// Answer 6: To use a view component tag helper in Razor views, you can use the <vc:component-name> syntax. Example:
// Using a View Component Tag Helper:
< vc:my - view - component ></ vc:my - view - component >

