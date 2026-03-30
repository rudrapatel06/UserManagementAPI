var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();

var app = builder.Build();

// Use custom logging middleware
app.UseLoggingMiddleware();

// Map controllers
app.MapControllers();

app.Run();
