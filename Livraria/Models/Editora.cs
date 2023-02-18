using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria.Models
{
    public class Editora
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(150)]
        public string Nome { get; set; }

        public List<Livro> Livros { get; set; }
    }
}
