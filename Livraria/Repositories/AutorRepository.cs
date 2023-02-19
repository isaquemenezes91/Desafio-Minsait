using Livraria.Data;
using Livraria.Models;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Repositories
{
    public class LivroRepository : IAutorRepository
    {
        public readonly LivrariaContext _context;

        public LivroRepository(LivrariaContext context)
        {
            _context = context;
        }

        public async Task<Autor> Create(Autor autor)
        {
            _context.Autores.Add(autor); 
            await _context.SaveChangesAsync();
            return autor;
        }

        public async Task<IEnumerable<Autor>> GetAll()
        {
           return await _context.Autores.ToListAsync();
        }

        public async Task<Autor> Get(string nome)
        {
            return await _context.Autores.FindAsync(nome);
        }
        public async Task<Autor> GetId(int Id)
        {
            return await _context.Autores.FindAsync(Id);
        }

        public async Task Update(Autor autor)
        {
            _context.Entry(autor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int Id)
        {
            var DeleteAutor= await _context.Autores.FindAsync(Id);
            _context.Autores.Remove(DeleteAutor);

            await _context.SaveChangesAsync();
        }




    }
}
