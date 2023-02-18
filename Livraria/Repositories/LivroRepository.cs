using Livraria.Data;
using Livraria.Models;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        public readonly LivrariaContext _context;

        public LivroRepository(LivrariaContext context)
        {
            _context = context;
        }

        public async Task<Livro> Create(Livro livro)
        {
            _context.Livros.Add(livro); 
            await _context.SaveChangesAsync();
            return livro;
        }

        public async Task<IEnumerable<Livro>> GetAll()
        {
           return await _context.Livros.ToListAsync();
        }

        public async Task<Livro> Get(string nome)
        {
            return await _context.Livros.FindAsync(nome);
        }
        public async Task<Livro> GetId(int Id)
        {
            return await _context.Livros.FindAsync(Id);
        }

        public async Task Update(Livro livro)
        {
            _context.Entry(livro).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int Id)
        {
            var DeleteLivro = await _context.Livros.FindAsync(Id);
            _context.Livros.Remove(DeleteLivro);

            await _context.SaveChangesAsync();
        }




    }
}
