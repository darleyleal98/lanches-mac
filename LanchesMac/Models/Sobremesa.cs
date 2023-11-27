using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Sobremesa")]
    public class Sobremesa
    {
        [Key]
        public int SobremesaId { get; set; }

        [Required(ErrorMessage = "O nome da sobremesa deve ser informado!")]
        [Display(Name = "Nome da sobremesa")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O deve ter no mínimo {10} caracteres e no máximo {80}")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição da sobremesa deve ser informada")]
        [Display(Name = "Descrição da sobremesa")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracter")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no máximo {200} caracteres")]
        public string DescricaoCurta { get; set; }

        [StringLength(200, MinimumLength = 20, ErrorMessage = "O deve ter no mínimo {20} caracteres e no máximo {200}")]
        [Required(ErrorMessage = "Informe o nome da categoria")]
        [Display(Name = "Descrição detalhada da sobremesa")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Informe o preço da sobremesa")]
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

        [Display(Name = "Sobremesa preferida?")]
        public bool IsSobremesaPreferida { get; set; }

        [Display(Name = "Em estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}