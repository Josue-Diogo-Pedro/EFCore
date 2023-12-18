using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cursov1.Migrations
{
    public partial class Propagacao3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "sequencias");

            migrationBuilder.AlterDatabase(
                collation: "SQL_Latin1_General_CP1_CI_AI");

            migrationBuilder.CreateSequence<int>(
                name: "MinhaSequencia",
                schema: "sequencias",
                startValue: 100L);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Departamentos",
                type: "nvarchar(450)",
                nullable: true,
                collation: "SQL_Latin1_General_CP1_CS_AS",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Departamentos",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR sequencias.MinhaSequencia",
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "Estados",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Sao Paulo" });

            migrationBuilder.InsertData(
                table: "Estados",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 2, "Sergipe" });

            migrationBuilder.CreateIndex(
                name: "idx_meu_indice_composto",
                table: "Departamentos",
                columns: new[] { "Descricao", "Ativo" },
                unique: true,
                filter: "Descricao IS NOT NULL")
                .Annotation("SqlServer:FillFactor", 80);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "idx_meu_indice_composto",
                table: "Departamentos");

            migrationBuilder.DropSequence(
                name: "MinhaSequencia",
                schema: "sequencias");

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterDatabase(
                oldCollation: "SQL_Latin1_General_CP1_CI_AI");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Departamentos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true,
                oldCollation: "SQL_Latin1_General_CP1_CS_AS");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Departamentos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "NEXT VALUE FOR sequencias.MinhaSequencia")
                .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
