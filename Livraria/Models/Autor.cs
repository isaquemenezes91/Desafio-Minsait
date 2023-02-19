using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Livraria.Models
{
    public class Autor
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Nome { get; set; }


    }
}
