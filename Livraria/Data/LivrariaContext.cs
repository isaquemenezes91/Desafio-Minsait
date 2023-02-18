using Livraria.Models;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Data
{
    public class LivrariaContext: DbContext
    {
        public DbSet<Livro> Livros { get; set; }

        public DbSet<Autor> Autores { get; set; }

        public LivrariaContext(DbContextOptions options) : base(options) { }

        public LivrariaContext(string conectionString) : base() { }

        protected override void OnModelCreating(ModelBuilder builder) {  }
    }
}
