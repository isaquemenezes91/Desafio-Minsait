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

        [Required]
        public int Editora_Id { get; set; }

        [ForeignKey("Editora_Id")]
        public List<Livro> Livros { get; set; }
    }
}
