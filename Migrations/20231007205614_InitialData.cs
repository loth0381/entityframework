using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace projectef.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Descripcion", "Nombre", "Peso" },
                values: new object[,]
                {
                    { new Guid("3f96cc4c-a2ae-4862-a47d-0dc15d150502"), null, "Actividades pedientes", 20 },
                    { new Guid("3f96cc4c-a2ae-4862-a47d-0dc15d150594"), null, "Actividades personales", 50 }
                });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaId", "CategoriaId", "CategoriaId1", "Descripcion", "FechaCreacion", "Titulo", "prioridadTarea" },
                values: new object[,]
                {
                    { new Guid("3f96cc4c-a2ae-4862-a47d-0dc15d150510"), new Guid("3f96cc4c-a2ae-4862-a47d-0dc15d150502"), null, null, new DateTime(2023, 10, 7, 15, 56, 14, 790, DateTimeKind.Local).AddTicks(2950), "Pago de servicios publico", 1 },
                    { new Guid("3f96cc4c-a2ae-4862-a47d-0dc15d150511"), new Guid("3f96cc4c-a2ae-4862-a47d-0dc15d150594"), null, null, new DateTime(2023, 10, 7, 15, 56, 14, 790, DateTimeKind.Local).AddTicks(2962), "Terminar pelicula netflix", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("3f96cc4c-a2ae-4862-a47d-0dc15d150510"));

            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("3f96cc4c-a2ae-4862-a47d-0dc15d150511"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("3f96cc4c-a2ae-4862-a47d-0dc15d150502"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("3f96cc4c-a2ae-4862-a47d-0dc15d150594"));

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
