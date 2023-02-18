﻿using System.ComponentModel.DataAnnotations;

namespace Livraria.Models
{
    public class Autor
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Nome { get; set; }

        public DateOnly? Data_nascimento { get; set; }

        public List<Livro> Livros { get; set; }
    }
}
