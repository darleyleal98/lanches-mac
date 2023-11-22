using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO Lanches(CategoriaId, 
                                         DescricaoCurta, 
                                         DescricaoDetalhada, 
                                         EmEstoque, 
                                         ImagemThumbnailUrl, 
                                         ImagemUrl, 
                                         IslanchePreferido, 
                                         Nome, 
                                         Preco) 
                   VALUES (1, 
                           'Pão, hambúrguer, ovo, presunto, queijo e batata', 
                           'Delicioso pão de hambúrguer de primeira qualidade acompanhado com batata palha', 
                           1, 
                           'http://www.macoratti.net/Imagens/Lanches/cheesesalada.jpg', 
                           0, 
                           'Cheese Salada', 
                           12.50);");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
