var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var tasks = new List<string> { "Task1", "Task2", "Task3" };

app.MapGet("/", () => tasks);

app.Run();