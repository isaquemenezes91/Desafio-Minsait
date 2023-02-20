using Livraria.Data.Context;
using Livraria.Data.Interfaces;
using Livraria.Models;

namespace Livraria.Data.Repositories
{
    public class AutorRepository : IAutorRepository
    {
        private readonly LivrariaContext _ctx;

        public AutorRepository (LivrariaContext context)
        {
            _ctx = context;
        }

        public void AdicionarAutor(Autor autor)
        {
            _ctx.Autores.Add(autor);
            _ctx.SaveChanges();
        }

        public void AtualizarAutor(Autor autor)
        {
            _ctx.Autores.Update(autor);
            _ctx.SaveChanges();
        }


        public Autor BuscarIdAutor(int Id)
        {
            return _ctx.Autores
                .FirstOrDefault(i => i.Id.Equals(Id));
        }

        public void DeleteAutor(Autor autor)
        {
            _ctx.Autores.Remove(autor);
        }

        public void SaveChanges()
        {
            _ctx.SaveChanges();
        }

    }
}
