using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniBot.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInical : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diccionario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Consulta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Respuesta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diccionario", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Diccionario",
                columns: new[] { "Id", "Consulta", "FechaCreacion", "FechaModificacion", "Respuesta" },
                values: new object[,]
                {
                    { new Guid("3940e524-a04c-434b-924d-78e6464b7309"), "¿Tienen productos sin gluten?", new DateTime(2024, 7, 5, 0, 7, 5, 200, DateTimeKind.Local).AddTicks(9231), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sí, tenemos una sección dedicada a productos sin gluten. Puedes pedir más información a nuestro personal en la tienda." },
                    { new Guid("71230187-5936-444f-9bf5-8f33e7117983"), "¿Cuáles son los horarios de apertura?", new DateTime(2024, 7, 5, 0, 7, 5, 200, DateTimeKind.Local).AddTicks(9195), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Estamos abiertos de lunes a sábado de 8:00 AM a 8:00 PM y los domingos de 9:00 AM a 6:00 PM." },
                    { new Guid("7366a0c4-3a8d-4c54-867d-0a847e4c783a"), "No reconocida", new DateTime(2024, 7, 5, 0, 7, 5, 200, DateTimeKind.Local).AddTicks(9239), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lo siento, no tengo contexto para responder tu pregunta, podrias darme mas detalles para ayudarte." },
                    { new Guid("81c560eb-7647-4bf7-9cdc-5791530bd65b"), " ¿Puedo hacer un pedido especial?", new DateTime(2024, 7, 5, 0, 7, 5, 200, DateTimeKind.Local).AddTicks(9228), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sí, aceptamos pedidos especiales. Por favor, llámanos al (123) 456-7890 para más detalles." },
                    { new Guid("8d867bcf-ce03-4de8-bef9-53da3bc3afc3"), "¿Cuáles son las promociones actuales?", new DateTime(2024, 7, 5, 0, 7, 5, 200, DateTimeKind.Local).AddTicks(9211), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Actualmente, tenemos una promoción de 2x1 en productos seleccionados. Puedes ver todas nuestras ofertas en nuestra página de promociones." },
                    { new Guid("9ef80278-ffb9-4878-a612-a35be8d1d1d6"), "¿Ofrecen servicio de entrega a domicilio?", new DateTime(2024, 7, 5, 0, 7, 5, 200, DateTimeKind.Local).AddTicks(9200), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sí, ofrecemos servicio de entrega a domicilio. Puedes realizar tu pedido en línea o llamarnos al (123) 456-7890." },
                    { new Guid("a2944e6f-7284-42e6-94b3-e4ceb2ed1d11"), "Saludo", new DateTime(2024, 7, 5, 0, 7, 5, 200, DateTimeKind.Local).AddTicks(9173), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hola! Soy Boti tu asistente virtual, como puedo ayudarte?" },
                    { new Guid("a41c12c3-4f77-4bb2-bbe9-931df9f4a419"), "¿Puedo devolver un producto?", new DateTime(2024, 7, 5, 0, 7, 5, 200, DateTimeKind.Local).AddTicks(9234), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sí, aceptamos devoluciones dentro de los 30 días de la compra con el recibo original." },
                    { new Guid("afbdd69f-f3ee-42bc-bda4-4f64c4af0077"), "¿Tienen productos orgánicos?", new DateTime(2024, 7, 5, 0, 7, 5, 200, DateTimeKind.Local).AddTicks(9208), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sí, contamos con una variedad de productos orgánicos en nuestra tienda." },
                    { new Guid("b3843922-f63e-4666-abd7-14cfaeebb41e"), "¿Dónde están ubicados?", new DateTime(2024, 7, 5, 0, 7, 5, 200, DateTimeKind.Local).AddTicks(9197), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Estamos ubicados en la calle Principal, número 123, en el centro de la ciudad" },
                    { new Guid("d33c1fd3-6563-43d8-9d10-c22926a835d4"), "¿Tienen un programa de fidelización?", new DateTime(2024, 7, 5, 0, 7, 5, 200, DateTimeKind.Local).AddTicks(9237), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sí, tenemos un programa de fidelización. Puedes registrarte en nuestra tienda y empezar a acumular puntos con cada compra." },
                    { new Guid("d6f035df-3d20-409d-9488-7acbfb05a11f"), "¿Aceptan tarjetas de crédito?", new DateTime(2024, 7, 5, 0, 7, 5, 200, DateTimeKind.Local).AddTicks(9203), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sí, aceptamos todas las tarjetas de crédito y débito principales." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diccionario");
        }
    }
}
