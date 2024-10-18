var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection(); // Ensures all requests are served over HTTPS.

app.UseAuthorization(); // Adds authorization middleware to check for user roles.

app.MapControllers(); // Maps incoming HTTP requests to controller actions.

app.Run();
