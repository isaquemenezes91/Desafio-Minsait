using System.ComponentModel.DataAnnotations;

namespace Livraria.Models.Dtos
{
    public class AutorDto
    {
        [Required]
        public int LivroId { get; set; }

        [Required]
        public string Nome { get; set; }
    }
}
