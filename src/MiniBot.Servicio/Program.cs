using MiniBot.Infraestructura.Persistencia;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Leer variables de entorno
string azureAppUri = Environment.GetEnvironmentVariable("AZURE_APP_URI") ?? "";


// dependencias de datos

builder.Services.AddDependenciasDeDatos(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.IniciarMigracionDeDatos();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapGet("/enviroment", () => new { uri = azureAppUri });

app.MapControllers();

app.Run();
