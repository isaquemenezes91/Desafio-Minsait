using System.ComponentModel.DataAnnotations;

namespace Livraria.Models
{
    public class Livro
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Titulo { get; set; }

        [MaxLength(100)]
        public string Subtitulo { get; set; }

        [MaxLength(500)]
        public string Resumo { get; set; }

        [Required]
        public int Quantidade_de_paginas { get; set; }

        [Required,Range(1,10000)]
        public DateOnly Data_de_publicacao { get; set; }


    }
}
