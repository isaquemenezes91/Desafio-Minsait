using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Livraria.Models.Dtos
{
    public class LivroDto
    {

        [Required(ErrorMessage = "Campo Nome é obrigatório")]
        public string Titulo { get; set; }

        [MaxLength(100)]
        public string? Subtitulo { get; set; }

        [MaxLength(500)]
        public string? Resumo { get; set; }

        [Required(ErrorMessage="Campo Nome é obrigatório")]
        public int QuantidadePaginas { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatório")]
        public string DataPublicacao { get; set; }

        [Range(1, 20)]
        public int? Edicao { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatório")]
        [Range(0, 1000)]
        public int QuantidadeEstoque { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatório")]
        [MaxLength(150)]
        public string Editora { get; set; }

        public ICollection<Autor> Autores { get; set; }

    }
}
