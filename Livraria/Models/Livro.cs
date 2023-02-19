using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Livraria.Models
{
    public class Livro
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Titulo { get; set; }

        [MaxLength(100)]
        public string? Subtitulo { get; set; }

        [MaxLength(500)]
        public string? Resumo { get; set; }

        [Required, Range(1,10000)]
        public int Quantidade_de_paginas { get; set; }

        [Required,MaxLength(10)]
        public string Data_de_publicacao { get; set; }

        [Range(1,20)]
        public int Edicao { get; set; }

        [Required,Range(0,1000)]
        public int Quantidade_estoque { get; set; }

        [Required,MaxLength(150)]
        public string Editora { get; set; }

        [ForeignKey("LivroId")]
        public ICollection<Autor> Autores { get; set; }
        



    }
}
