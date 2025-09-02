var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Simple GET endpoint at "/hello"
app.MapGet("/hello", () => "Hello, this is a simple .NET API!");

app.Run();
