using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoEscolaPeDeChumbo.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    funcionario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idade = table.Column<int>(type: "int", nullable: false),
                    saldo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    possuiCNH = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    funcionario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idade = table.Column<int>(type: "int", nullable: false),
                    dependentes = table.Column<int>(type: "int", nullable: false),
                    salBruto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    cargo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aluno");

            migrationBuilder.DropTable(
                name: "Funcionario");
        }
    }
}
