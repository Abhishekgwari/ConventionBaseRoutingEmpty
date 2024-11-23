var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();       
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

// app.MapDefaultControllerRoute();    this will call home controller 
//      and its index  action method
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=about}/{id?}");


app.MapControllers();  // this middleware is used to perform
                       // attribute base routing
app.Run();