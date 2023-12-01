using Microsoft.EntityFrameworkCore.Migrations;

namespace LanchesMac.Migrations
{
    public partial class PovoandoACategoriaDeBebidas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO Bebida( 
                                Nome,
                                DescricaoCurta,
                                DescricaoDetalhada,
                                Preco,
                                ImagemUrl,
                                ImagemThumbnail, 
                                IsBebidaFavorita
                                EmEstoque
                                ) 
       VALUES ( 
               'Suco de laranja natural', 
               1, 
               'https://th.bing.com/th/id/R.1f5705f9204f7b1f775aa7ff094c955d?rik=86xkWmSpp21D9w&riu=http%3a%2f%2f3.bp.blogspot.com%2f-IOGRfDTrKos%2fVe4k1Kdcq9I%2fAAAAAAAACnc%2fDVBeEFkL9sI%2fs1600%2f20150523.jpg&ehk=QwP9om4Vdsq3lOpou3S96oTwZLJw%2fOLTUGD2vbQ%2b1sI%3d&risl=&pid=ImgRaw&r=0', 
               'https://th.bing.com/th/id/R.1f5705f9204f7b1f775aa7ff094c955d?rik=86xkWmSpp21D9w&riu=http%3a%2f%2f3.bp.blogspot.com%2f-IOGRfDTrKos%2fVe4k1Kdcq9I%2fAAAAAAAACnc%2fDVBeEFkL9sI%2fs1600%2f20150523.jpg&ehk=QwP9om4Vdsq3lOpou3S96oTwZLJw%2fOLTUGD2vbQ%2b1sI%3d&risl=&pid=ImgRaw&r=0', 
               'Suco de Laranja', 
               5.00);"
            );

            migrationBuilder.Sql(@"INSERT INTO Bebida( 
                                Nome,
                                DescricaoCurta,
                                DescricaoDetalhada,
                                Preco,
                                ImagemUrl,
                                ImagemThumbnail, 
                                IsBebidaFavorita
                                EmEstoque
                                )
       VALUES ( 
               'Suco de maçã', 
               1, 
               'https://th.bing.com/th/id/OIP.d1k0kMsM_0kquurcTRdpTwHaE7?rs=1&pid=ImgDetMain', 
               'https://th.bing.com/th/id/OIP.d1k0kMsM_0kquurcTRdpTwHaE7?rs=1&pid=ImgDetMain', 
               'Suco de Maçã', 
               4.50);"
            );

            migrationBuilder.Sql(@"INSERT INTO Bebida( 
                                Nome,
                                DescricaoCurta,
                                DescricaoDetalhada,
                                Preco,
                                ImagemUrl,
                                ImagemThumbnail, 
                                IsBebidaFavorita
                                EmEstoque
                                ) 
       VALUES ( 
               'Limonada suiça com folhas de hortelã', 
               1, 
               'https://th.bing.com/th/id/R.e6b244af0ef227670da4258800cbdf88?rik=wa2DYe41MDPz1Q&pid=ImgRaw&r=0', 
               'https://th.bing.com/th/id/R.e6b244af0ef227670da4258800cbdf88?rik=wa2DYe41MDPz1Q&pid=ImgRaw&r=0', 
               'Limonada', 
               6.00);"
            );

            migrationBuilder.Sql(@"INSERT INTO Bebida( 
                                Nome,
                                DescricaoCurta,
                                DescricaoDetalhada,
                                Preco,
                                ImagemUrl,
                                ImagemThumbnail, 
                                IsBebidaFavorita
                                EmEstoque
                                ) 
       VALUES ( 
               'Smoothie de frutas vermelhas', 
               1, 
               'https://img.imageboss.me/kitchenaid/cdn/animation:true/2022/01/20220126171108-KAD_Blog_smoothie-frutas-vermelhas_1920x1080.png', 
               'https://img.imageboss.me/kitchenaid/cdn/animation:true/2022/01/20220126171108-KAD_Blog_smoothie-frutas-vermelhas_1920x1080.png', 
               'Smoothie de Frutas Vermelhas', 
               7.50);"
            );

            migrationBuilder.Sql(@"INSERT INTO Bebida( 
                                Nome,
                                DescricaoCurta,
                                DescricaoDetalhada,
                                Preco,
                                ImagemUrl,
                                ImagemThumbnail, 
                                IsBebidaFavorita
                                EmEstoque
                                )  
       VALUES ( 
               'Chá gelado com limão e menta', 
               1, 
               'https://img-21.ccm2.net/nGbFTQzmFhf--W4oWwkqZwUmR-U=/2ec445882e6c4dad82ce46ca0ffacdfe/ccm-faq/1067854.jpg', 
               'https://img-21.ccm2.net/nGbFTQzmFhf--W4oWwkqZwUmR-U=/2ec445882e6c4dad82ce46ca0ffacdfe/ccm-faq/1067854.jpg', 
               'Chá Gelado', 
               4.00);"
            );

            migrationBuilder.Sql(@"INSERT INTO Bebida( 
                                Nome,
                                DescricaoCurta,
                                DescricaoDetalhada,
                                Preco,
                                ImagemUrl,
                                ImagemThumbnail, 
                                IsBebidaFavorita
                                EmEstoque
                                )
       VALUES ( 
               'Água de coco natural', 
               1, 
               'https://www.saudevitalidade.com/wp-content/uploads/2019/02/10-beneficios-da-agua-de-coco-para-a-sua-saude.jpg', 
               'https://www.saudevitalidade.com/wp-content/uploads/2019/02/10-beneficios-da-agua-de-coco-para-a-sua-saude.jpg', 
               'Água de Coco', 
               3.50);"
            );

            migrationBuilder.Sql(@"INSERT INTO Bebida( 
                                Nome,
                                DescricaoCurta,
                                DescricaoDetalhada,
                                Preco,
                                ImagemUrl,
                                ImagemThumbnail, 
                                IsBebidaFavorita
                                EmEstoque
                                ) 
       VALUES ( 
               'Café gelado com leite e caramelo', 
               1, 
               'https://www.guiadasemana.com.br/contentFiles/image/2018/11/FEA/50780_shutterstock-425292718.jpg', 
               'https://www.guiadasemana.com.br/contentFiles/image/2018/11/FEA/50780_shutterstock-425292718.jpg', 
               'Café Gelado', 
               5.50);"
            );

            migrationBuilder.Sql(@"INSERT INTO Bebida( 
                                Nome,
                                DescricaoCurta,
                                DescricaoDetalhada,
                                Preco,
                                ImagemUrl,
                                ImagemThumbnail, 
                                IsBebidaFavorita
                                EmEstoque
                                )
       VALUES (
               'Milkshake de frutas vermelhas', 
               1, 
               'https://virtualsmokies.com/wp-content/uploads/2022/08/crazy-mason-milkshake-bar.jpg', 
               'https://virtualsmokies.com/wp-content/uploads/2022/08/crazy-mason-milkshake-bar.jpg', 
               'Milkshake de Morango', 
               8.00);"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
