using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cursov1.Migrations
{
    public partial class Propagacao2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Estado",
                table: "Estado");

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameTable(
                name: "Estado",
                newName: "Estados");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estados",
                table: "Estados",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Estados",
                table: "Estados");

            migrationBuilder.RenameTable(
                name: "Estados",
                newName: "Estado");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estado",
                table: "Estado",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Sao Paulo" });

            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 2, "Sergipe" });
        }
    }
}
