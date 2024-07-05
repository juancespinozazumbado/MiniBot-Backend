﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MiniBot.Dominio.Servicios;
using MiniBot.Infraestructura.Servicios;

namespace MiniBot.Infraestructura.Persistencia;

public static class DependenciasDeDatos
{
    public static IServiceCollection AddDependenciasDeDatos(this IServiceCollection services, IConfiguration configuration)
    {

        
        var cadenaDeConeccion = configuration.GetConnectionString("SQLITE");
        //var cadenaDeConeccion = Environment.GetEnvironmentVariable("DATABASE_CONNECTION_STRING");
        services.AddDbContext<ChatBotDbContext>(options => options.UseSqlite(cadenaDeConeccion));

        return services;

    }


    public static IServiceCollection AddServiciosDeChat( this IServiceCollection services)
    {

        services.AddScoped<IServicioChat, ServicioChat>();

        return services;
    }
}
