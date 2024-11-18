var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

// Explanations:

// Controllers: The controllers are the classes that handle the requests and responses,
// controllers are the ones that are in charge of the business logic and the data access.

// Action: The action is the method that is called when a request is made to the controller.

// Model: The model is the data that is used to render the view.

 // Razor: The razor is the template engine that is used to render the view.
 
 // RazorView: The razor view is the view that is rendered by the razor template engine.
 
 // wwwroot: The wwwroot is the folder that contains the static files that are served by the web server.
 
 // builder.Build(): The builder.Build() method is used to build the web application.
 
 // app.Run(): The app.Run() method is used to start the web application.