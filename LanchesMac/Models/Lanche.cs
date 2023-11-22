using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "O nome do lanche deve ser informado!")]
        [Display(Name = "Nome do lanche")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O deve ter no mínimo {10} caracteres e no máximo {80}")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição do lanche deve ser informada")]
        [Display(Name = "Descrição do lanche")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracter")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no máximo {200} caracteres")]
        public string DescricaoCurta { get; set; }

        [StringLength(200, MinimumLength = 20, ErrorMessage = "O deve ter no mínimo {20} caracteres e no máximo {200}")]
        [Required(ErrorMessage = "Informe o nome da categoria")]
        [Display(Name = "Descrição detalhada do lanche")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Informe o preço do lanche")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "o preço do produto deve estar entre  R$ 1,00 e R$ 999,99")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho da imagem do tamanho normal")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O deve ter no mínimo {20} caracteres e no máximo {200}")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho da imagem em miniatura")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O deve ter no mínimo {20} caracteres e no máximo {200}")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Lanche preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Em estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}