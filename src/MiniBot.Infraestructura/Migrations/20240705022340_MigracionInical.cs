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
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Consulta = table.Column<string>(type: "TEXT", nullable: true),
                    Respuesta = table.Column<string>(type: "TEXT", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                    { new Guid("062bc82d-a4c8-41f4-936d-e823b3b56b33"), "Saludo", new DateTime(2024, 7, 4, 20, 23, 39, 711, DateTimeKind.Local).AddTicks(5693), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hola! Soy Boti tu asistente virtual, como puedo ayudarte?" },
                    { new Guid("2fd2e2b7-9660-4845-acb4-afcd59b5fea9"), "¿Cuáles son los horarios de apertura?", new DateTime(2024, 7, 4, 20, 23, 39, 711, DateTimeKind.Local).AddTicks(5719), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Estamos abiertos de lunes a sábado de 8:00 AM a 8:00 PM y los domingos de 9:00 AM a 6:00 PM." },
                    { new Guid("36bd3697-9084-4e25-b77e-9de2b92536fb"), "¿Dónde están ubicados?", new DateTime(2024, 7, 4, 20, 23, 39, 711, DateTimeKind.Local).AddTicks(5723), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Estamos ubicados en la calle Principal, número 123, en el centro de la ciudad" },
                    { new Guid("4472b17f-b6d1-4388-b9c7-85cecc1c709a"), "¿Tienen un programa de fidelización?", new DateTime(2024, 7, 4, 20, 23, 39, 711, DateTimeKind.Local).AddTicks(5767), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sí, tenemos un programa de fidelización. Puedes registrarte en nuestra tienda y empezar a acumular puntos con cada compra." },
                    { new Guid("54c8aea3-36c5-49bc-8acc-af6aaa133996"), "¿Ofrecen servicio de entrega a domicilio?", new DateTime(2024, 7, 4, 20, 23, 39, 711, DateTimeKind.Local).AddTicks(5744), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sí, ofrecemos servicio de entrega a domicilio. Puedes realizar tu pedido en línea o llamarnos al (123) 456-7890." },
                    { new Guid("8f2805ed-c43e-4662-a132-3c4c7b625b2c"), " ¿Puedo hacer un pedido especial?", new DateTime(2024, 7, 4, 20, 23, 39, 711, DateTimeKind.Local).AddTicks(5759), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sí, aceptamos pedidos especiales. Por favor, llámanos al (123) 456-7890 para más detalles." },
                    { new Guid("944098e8-e1da-4ad4-aecc-1cd2caf4d2f2"), "¿Tienen productos sin gluten?", new DateTime(2024, 7, 4, 20, 23, 39, 711, DateTimeKind.Local).AddTicks(5761), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sí, tenemos una sección dedicada a productos sin gluten. Puedes pedir más información a nuestro personal en la tienda." },
                    { new Guid("94fb4cd5-1b96-4261-80cd-c82990a29050"), "¿Puedo devolver un producto?", new DateTime(2024, 7, 4, 20, 23, 39, 711, DateTimeKind.Local).AddTicks(5765), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sí, aceptamos devoluciones dentro de los 30 días de la compra con el recibo original." },
                    { new Guid("9da672a5-68a2-41bb-9b20-415c12302aa6"), "¿Cuáles son las promociones actuales?", new DateTime(2024, 7, 4, 20, 23, 39, 711, DateTimeKind.Local).AddTicks(5757), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Actualmente, tenemos una promoción de 2x1 en productos seleccionados. Puedes ver todas nuestras ofertas en nuestra página de promociones." },
                    { new Guid("c69ee254-2123-4b33-a434-c00f7988b3d6"), "¿Tienen productos orgánicos?", new DateTime(2024, 7, 4, 20, 23, 39, 711, DateTimeKind.Local).AddTicks(5755), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sí, contamos con una variedad de productos orgánicos en nuestra tienda." },
                    { new Guid("db32d32d-3413-4955-91bc-37c72afe2f47"), "¿Aceptan tarjetas de crédito?", new DateTime(2024, 7, 4, 20, 23, 39, 711, DateTimeKind.Local).AddTicks(5746), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sí, aceptamos todas las tarjetas de crédito y débito principales." },
                    { new Guid("ebd595fc-f0fc-4539-9206-6506bd7a8241"), "No reconocida", new DateTime(2024, 7, 4, 20, 23, 39, 711, DateTimeKind.Local).AddTicks(5773), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lo siento, no tengo contexto para responder tu pregunta, podrias darme mas detalles para ayudarte." }
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
