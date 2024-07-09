using MiniBot.Infraestructura.Persistencia;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Leer variables de entorno

builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true)
    .AddEnvironmentVariables();
//string azureAppUri = Environment.GetEnvironmentVariable("AZURE_APP_URI") ?? "";


// dependencias de datos

builder.Services.AddDependenciasDeDatos(builder.Configuration);
builder.Services.AddServiciosDeChat();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAnyOrigin",
        builder => builder.AllowAnyOrigin()
                          .AllowAnyHeader()
                          .AllowAnyMethod());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

    //app.IniciarMigracionDeDatos();

}

// en caso de usar base de datos inMemmory
app.IniciarMigracionDeDatos();




app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseCors("AllowAnyOrigin");

app.UseAuthorization();


app.MapControllers();

app.Run();
