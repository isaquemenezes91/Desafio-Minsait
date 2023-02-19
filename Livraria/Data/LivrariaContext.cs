using Livraria.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Livraria.Data
{
    public class LivrariaContext: DbContext
    {
        public DbSet<Livro> Livros { get; set; }

        public DbSet<Autor> Autores { get; set; }

        public LivrariaContext(DbContextOptions<LivrariaContext> options) : base(options) { }

        public LivrariaContext(string conectionString) : base() { }

        protected override void OnModelCreating(ModelBuilder builder) { base.OnModelCreating(builder); }
    }
}
