var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Simple GET endpoint at "/hello"
app.MapGet("/hello", () => "Hello, this is a simple .NET API!");

// Another example GET endpoint at "/weather"
app.MapGet("/weather", () =>
{
    var summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    var forecast = Enumerable.Range(1, 5).Select(index => new
    {
        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        TemperatureC = Random.Shared.Next(-20, 55),
        Summary = summaries[Random.Shared.Next(summaries.Length)]
    });

    return forecast;
});

app.Run();
