using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    /// <inheritdoc />
    public partial class CarrinhoCompraItens : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarrinhoCompraItem",
                columns: table => new
                {
                    CarrinhoCompraItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LancheId = table.Column<int>(type: "int", nullable: true),
                    SobremesaId = table.Column<int>(type: "int", nullable: true),
                    BebidaId = table.Column<int>(type: "int", nullable: true),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    CarrinhoCompraId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoCompraItem", x => x.CarrinhoCompraItemId);
                    table.ForeignKey(
                        name: "FK_CarrinhoCompraItem_Bebida_BebidaId",
                        column: x => x.BebidaId,
                        principalTable: "Bebida",
                        principalColumn: "BebidaId");
                    table.ForeignKey(
                        name: "FK_CarrinhoCompraItem_Lanches_LancheId",
                        column: x => x.LancheId,
                        principalTable: "Lanches",
                        principalColumn: "LancheId");
                    table.ForeignKey(
                        name: "FK_CarrinhoCompraItem_Sobremesa_SobremesaId",
                        column: x => x.SobremesaId,
                        principalTable: "Sobremesa",
                        principalColumn: "SobremesaId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoCompraItem_BebidaId",
                table: "CarrinhoCompraItem",
                column: "BebidaId");

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoCompraItem_LancheId",
                table: "CarrinhoCompraItem",
                column: "LancheId");

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoCompraItem_SobremesaId",
                table: "CarrinhoCompraItem",
                column: "SobremesaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarrinhoCompraItem");
        }
    }
}
