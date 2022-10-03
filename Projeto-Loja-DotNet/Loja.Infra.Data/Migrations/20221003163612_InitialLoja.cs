using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Loja.Infra.Data.Migrations
{
    public partial class InitialLoja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LojaMarilias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: false),
                    categoria = table.Column<string>(type: "TEXT", nullable: false),
                    cidade = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LojaMarilias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: false),
                    preco = table.Column<double>(type: "REAL", nullable: false),
                    qtde = table.Column<int>(type: "INTEGER", nullable: false),
                    LojaMariliaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_LojaMarilias_LojaMariliaId",
                        column: x => x.LojaMariliaId,
                        principalTable: "LojaMarilias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_LojaMariliaId",
                table: "Produtos",
                column: "LojaMariliaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "LojaMarilias");
        }
    }
}
