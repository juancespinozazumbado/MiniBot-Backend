
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
            new Diccionario { Consulta = "Saludo", Respuesta ="Hola! Soy Boti tu asistente virtual, como puedo ayudarte?"},
            new Diccionario { Consulta = "¿Cuáles son los horarios de apertura?", Respuesta ="Estamos abiertos de lunes a sábado de 8:00 AM a 8:00 PM y los domingos de 9:00 AM a 6:00 PM."},
            new Diccionario { Consulta = "¿Dónde están ubicados?", Respuesta ="Estamos ubicados en la calle Principal, número 123, en el centro de la ciudad"},
            new Diccionario { Consulta = "¿Ofrecen servicio de entrega a domicilio?", Respuesta ="Sí, ofrecemos servicio de entrega a domicilio. Puedes realizar tu pedido en línea o llamarnos al (123) 456-7890."},
            new Diccionario { Consulta = "¿Aceptan tarjetas de crédito?", Respuesta ="Sí, aceptamos todas las tarjetas de crédito y débito principales."},
            new Diccionario { Consulta = "¿Tienen productos orgánicos?", Respuesta ="Sí, contamos con una variedad de productos orgánicos en nuestra tienda."},
            new Diccionario { Consulta = "¿Cuáles son las promociones actuales?", Respuesta ="Actualmente, tenemos una promoción de 2x1 en productos seleccionados. Puedes ver todas nuestras ofertas en nuestra página de promociones."},
            new Diccionario { Consulta = " ¿Puedo hacer un pedido especial?", Respuesta ="Sí, aceptamos pedidos especiales. Por favor, llámanos al (123) 456-7890 para más detalles."},
            new Diccionario { Consulta = "¿Tienen productos sin gluten?", Respuesta ="Sí, tenemos una sección dedicada a productos sin gluten. Puedes pedir más información a nuestro personal en la tienda."},
            new Diccionario { Consulta = "¿Puedo devolver un producto?", Respuesta ="Sí, aceptamos devoluciones dentro de los 30 días de la compra con el recibo original."},
            new Diccionario { Consulta = "¿Tienen un programa de fidelización?", Respuesta ="Sí, tenemos un programa de fidelización. Puedes registrarte en nuestra tienda y empezar a acumular puntos con cada compra."},
            new Diccionario { Consulta = "No reconocida", Respuesta ="Lo siento, no tengo contexto para responder tu pregunta, podrias darme mas detalles para ayudarte."}


        });
    }
}
