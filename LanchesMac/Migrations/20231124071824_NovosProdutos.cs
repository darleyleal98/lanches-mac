using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class NovosProdutos : Migration
    {
        /// <inheritdoc />
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
               'http://www.macoratti.net/Imagens/Lanches/cheesesalada_thumb.jpg', 
               'http://www.macoratti.net/Imagens/Lanches/cheesesalada.jpg', 
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
               'Pão, frango grelhado, alface, tomate e maionese', 
               'Sanduíche saudável com peito de frango grelhado e vegetais frescos', 
               1, 
               'https://www.example.com/sandwich3_thumbnail.jpg', 
               'https://www.example.com/sandwich3.jpg', 
               0, 
               'Frango Grelhado', 
               10.00);"
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
               'Pão, rosbife, queijo suíço, cebola caramelizada e molho especial', 
               'Combinação irresistível de rosbife, queijo suíço e cebola caramelizada', 
               1, 
               'https://www.example.com/sandwich4_thumbnail.jpg', 
               'https://www.example.com/sandwich4.jpg', 
               0, 
               'Rosbife Especial', 
               14.50);"
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
               'Massa de pizza, molho de tomate, queijo, pepperoni e orégano', 
               'Saborosa pizza no formato de sanduíche com pepperoni e queijo derretido', 
               1, 
               'https://www.example.com/sandwich5_thumbnail.jpg', 
               'https://www.example.com/sandwich5.jpg', 
               0, 
               'Pizza Sandwich', 
               11.00);"
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
               'Pão, almôndegas, queijo, molho de tomate e orégano', 
               'Sanduíche irresistível com almôndegas suculentas, queijo e molho de tomate', 
               1, 
               'https://www.example.com/sandwich6_thumbnail.jpg', 
               'https://www.example.com/sandwich6.jpg', 
               0, 
               'Almôndega Sub', 
               13.00);"
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
               'Pão sírio, falafel, homus, alface, tomate e pepino', 
               'Delicioso sanduíche vegano com falafel, homus e vegetais frescos', 
               1, 
               'https://www.example.com/sandwich8_thumbnail.jpg', 
               'https://www.example.com/sandwich8.jpg', 
               0, 
               'Falafel Wrap', 
               10.50);"
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
               'Pão de hot dog, salsicha, molho de mostarda e ketchup', 
               'O clássico hot dog americano com salsicha, mostarda e ketchup', 
               1, 
               'https://www.example.com/sandwich9_thumbnail.jpg', 
               'https://www.example.com/sandwich9.jpg', 
               0, 
               'Hot Dog Clássico', 
               8.00);"
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
               'Pão de baguete, presunto, queijo, salame, alface e tomate', 
               'Sanduíche clássico com presunto, queijo, salame e vegetais frescos', 
               1, 
               'https://www.example.com/sandwich10_thumbnail.jpg', 
               'https://www.example.com/sandwich10.jpg', 
               0, 
               'Baguete Italiana', 
               11.00);"
            );

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
