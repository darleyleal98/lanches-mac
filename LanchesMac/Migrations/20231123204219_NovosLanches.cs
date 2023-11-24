using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class NovosLanches : Migration
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
                           'Pão, hambúrguer, bacon, carne desfiada, presunto, queijo e batata', 
                           'Delicioso pão de hambúrguer de primeira qualidade acompanhado de molho barbecue', 
                           1, 
                           https://th.bing.com/th/id/OIP.5utyQsCku3p2EeAtXuHkwwHaHa?rs=1&pid=ImgDetMain, 
                           0, 
                           'Cheese Bacon', 
                           12.50);"
            );

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
                           'Pão, hambúrguer, presunto, queijo e batata', 
                           'Delicioso pão de hambúrguer de primeira qualidade acompanhado com batata palha', 
                           1, 
                           'http://www.macoratti.net/Imagens/Lanches/cheesesalada_thumb.jpg', 
                           'http://www.macoratti.net/Imagens/Lanches/cheesesalada.jpg', 
                           0, 
                           'Cheese Burguer', 
                           12.50);"
            );
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
