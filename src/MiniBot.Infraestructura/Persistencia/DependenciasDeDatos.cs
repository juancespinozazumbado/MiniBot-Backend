
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MiniBot.Infraestructura.Persistencia;

public static class DependenciasDeDatos
{
    public static IServiceCollection AddDependenciasDeDatos(this IServiceCollection services, IConfiguration configuration)
    {


        var cadenaDeConeccion = configuration.GetConnectionString("SQLSERVER");
        services.AddDbContext<ChatBotDbContext>(options => options.UseSqlServer(cadenaDeConeccion));


        return services;

    }
}
