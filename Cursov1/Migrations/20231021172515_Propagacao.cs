using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cursov1.Migrations
{
    public partial class Propagacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Sao Paulo" });

            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 2, "Sergipe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estado");
        }
    }
}
