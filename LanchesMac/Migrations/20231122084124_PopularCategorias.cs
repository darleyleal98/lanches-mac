using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categoria(CategoriaNome, Descricao)" +
                "VALUES('Normal', 'Lanche feito com ingredeientes normais')");

            migrationBuilder.Sql("INSERT INTO Categoria(CategoriaNome, Descricao)" +
                "VALUES('Natural', 'Lanche feito com ingredeientes naturais')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categoria");
        }
    }
}
