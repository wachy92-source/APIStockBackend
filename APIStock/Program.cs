using APIStock;
using APIStock.Application;
using APIStock.Infrastructure;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

// Obtenemos connection string del appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Registramos capas
builder.Services.AddApplication();
builder.Services.AddInfrastructure(connectionString);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.UseDefaultFiles(); // sirve index.html por default
app.UseStaticFiles();  // permite servir wwwroot


app.MapControllers();
app.Run();
