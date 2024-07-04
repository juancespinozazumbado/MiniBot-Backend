
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
             dbCOntext.Database.Migrate();
             return app;
            

        }
        
    }
}
