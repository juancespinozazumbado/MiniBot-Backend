
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MiniBot.Infraestructura.Persistencia;

public static class ServicioDeMigracionDeDatos
{
    public static IApplicationBuilder IniciarMigracionDeDatos( this IApplicationBuilder app)
    {
        using (var serviceScope = app.ApplicationServices.CreateScope())
        {
            var dbCOntext = serviceScope.ServiceProvider.GetRequiredService<ChatBotDbContext>();

            // use esta configuracion en entornos inMemory 
            dbCOntext.Database.EnsureCreated();

            // para entornos reales con Motores de DB 
            //dbCOntext.Database.Migrate();

            return app;
            

        }
        
    }
}
