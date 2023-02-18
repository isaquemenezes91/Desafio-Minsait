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
        public string? Subtitulo { get; set; }

        [MaxLength(500)]
        public string? Resumo { get; set; }

        [Required]
        public int Quantidade_de_paginas { get; set; }

        [Required]
        public DateOnly Data_de_publicacao { get; set; }

        [Range(1,20)]
        public int Edicao { get; set; }

        [Required,Range(0,100)]
        public string Quantidade_estoque { get; set; }

        [Required]
        public Editora Editora { get; set; }

        [Required]
        public Autor Autor { get; set; }



    }
}
