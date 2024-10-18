var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers(); // Ensure this line is present

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Optional for development purposes
}

app.UseHttpsRedirection();

app.UseRouting(); // Ensure routing middleware is added

app.UseAuthorization();

app.MapControllers(); // Ensure controllers are mapped

app.Run();
