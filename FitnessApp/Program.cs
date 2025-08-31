var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles(); // serve wwwroot static files

// Map fallback to index.html so root URL loads your fitness app
app.MapFallbackToFile("index.html");

app.Run();
