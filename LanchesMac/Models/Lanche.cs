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
        public string  Nome { get; set; }

        [Required(ErrorMessage = "A descrição do lanche deve ser informada")]
        [Display(Name = "Descrição do lanche")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracter")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no máximo {200} caracteres")]
        public string  DescricaoCurta { get; set; }

        [NotMapped]
        public DateTime DataDeCriacao { get; set; }
        public string  DescricaoDetalhada { get; set; }
        public decimal  Preco { get; set; }
        public string  ImagemUrl { get; set; }
        public string  ImagemThumbnailUrl { get; set; }
        public bool  IsLanchePreferido { get; set; }
        public bool  EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
