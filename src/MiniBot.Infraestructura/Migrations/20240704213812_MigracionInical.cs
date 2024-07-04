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
                    { new Guid("01c04ace-8340-46d7-9428-5e94030b1ca4"), "¿Dónde están ubicados?", new DateTime(2024, 7, 4, 15, 38, 12, 187, DateTimeKind.Local).AddTicks(448), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Estamos ubicados en la calle Principal, número 123, en el centro de la ciudad" },
                    { new Guid("0e11f092-c91a-46c1-8434-51abbcd376a1"), "¿Aceptan tarjetas de crédito?", new DateTime(2024, 7, 4, 15, 38, 12, 187, DateTimeKind.Local).AddTicks(468), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sí, aceptamos todas las tarjetas de crédito y débito principales." },
                    { new Guid("4281108c-1071-4892-b421-213511b83a5a"), "¿Cuáles son los horarios de apertura?", new DateTime(2024, 7, 4, 15, 38, 12, 187, DateTimeKind.Local).AddTicks(446), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Estamos abiertos de lunes a sábado de 8:00 AM a 8:00 PM y los domingos de 9:00 AM a 6:00 PM." },
                    { new Guid("47a08b47-fe2a-48e2-95a3-026ae74bd4c1"), "¿Cuáles son las promociones actuales?", new DateTime(2024, 7, 4, 15, 38, 12, 187, DateTimeKind.Local).AddTicks(476), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Actualmente, tenemos una promoción de 2x1 en productos seleccionados. Puedes ver todas nuestras ofertas en nuestra página de promociones." },
                    { new Guid("55f26ffc-7363-4e9c-890b-cea43bc8cabf"), " ¿Puedo hacer un pedido especial?", new DateTime(2024, 7, 4, 15, 38, 12, 187, DateTimeKind.Local).AddTicks(478), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sí, aceptamos pedidos especiales. Por favor, llámanos al (123) 456-7890 para más detalles." },
                    { new Guid("7739767b-170b-4320-ab16-8c38330390a1"), "¿Puedo devolver un producto?", new DateTime(2024, 7, 4, 15, 38, 12, 187, DateTimeKind.Local).AddTicks(483), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sí, aceptamos devoluciones dentro de los 30 días de la compra con el recibo original." },
                    { new Guid("7ec82c6c-5aa4-427b-89e7-5d1fed3507e5"), "¿Tienen productos sin gluten?", new DateTime(2024, 7, 4, 15, 38, 12, 187, DateTimeKind.Local).AddTicks(480), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sí, tenemos una sección dedicada a productos sin gluten. Puedes pedir más información a nuestro personal en la tienda." },
                    { new Guid("8db4f9d5-ce82-4dce-9611-aafcbc53d0d4"), "¿Ofrecen servicio de entrega a domicilio?", new DateTime(2024, 7, 4, 15, 38, 12, 187, DateTimeKind.Local).AddTicks(465), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sí, ofrecemos servicio de entrega a domicilio. Puedes realizar tu pedido en línea o llamarnos al (123) 456-7890." },
                    { new Guid("deaeb7f8-dc05-4430-b36b-55d61ac6e5e1"), "¿Tienen un programa de fidelización?", new DateTime(2024, 7, 4, 15, 38, 12, 187, DateTimeKind.Local).AddTicks(484), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sí, tenemos un programa de fidelización. Puedes registrarte en nuestra tienda y empezar a acumular puntos con cada compra." },
                    { new Guid("dfc2d931-e678-4757-85f0-368dfc422906"), "", new DateTime(2024, 7, 4, 15, 38, 12, 187, DateTimeKind.Local).AddTicks(490), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lo siento, no tengo contexto para responder tu pregunta, podrias darme mas detalles para ayudarte." },
                    { new Guid("e4726597-1b36-4461-bab5-19a05b10471e"), "¿Tienen productos orgánicos?", new DateTime(2024, 7, 4, 15, 38, 12, 187, DateTimeKind.Local).AddTicks(474), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sí, contamos con una variedad de productos orgánicos en nuestra tienda." },
                    { new Guid("e7448ee4-d4aa-462e-b850-1b936f6df765"), "", new DateTime(2024, 7, 4, 15, 38, 12, 187, DateTimeKind.Local).AddTicks(426), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hola! Soy Boti tu asistente virtual, como puedo ayudarte?" }
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
