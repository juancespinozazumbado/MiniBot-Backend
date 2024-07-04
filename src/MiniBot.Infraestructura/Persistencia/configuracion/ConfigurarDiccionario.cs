
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniBot.Dominio.Entitdades.Chat;

namespace MiniBot.Infraestructura.Persistencia.configuracion;

internal class ConfigurarDiccionario : IEntityTypeConfiguration<Diccionario>
{
    public void Configure(EntityTypeBuilder<Diccionario> builder)
    {
        builder.ToTable("Diccionario");


        //poblar la tabla con las posibles consultas

        builder.HasData(new List<Diccionario>
        {
            new Diccionario { Consulta = "Hola", Respuesta ="Hola! Soy Boti tu asistente virtual, como puedo ayudarte?"},
            new Diccionario { Consulta = "", Respuesta =""},
            new Diccionario { Consulta = "", Respuesta =""},
            new Diccionario { Consulta = "", Respuesta =""},
            new Diccionario { Consulta = "", Respuesta =""},
            new Diccionario { Consulta = "", Respuesta =""},
            new Diccionario { Consulta = "", Respuesta =""},
            new Diccionario { Consulta = "", Respuesta =""},
            new Diccionario { Consulta = "", Respuesta =""},
            new Diccionario { Consulta = "", Respuesta =""}


        });
    }
}
