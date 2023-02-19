using Livraria.Data.Context;
using Livraria.Manager.Interfaces;
using Livraria.Models;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Data.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private LivrariaContext _ctx;

        public LivroRepository(LivrariaContext ctx)
        {
            _ctx = ctx;
        }

        public List<Livro> Buscar()
        {
            return _ctx.Livros.Include(i=>i.Autores).ToList();
        }

        public void Adicionar(Livro livro)
        {
            _ctx.Livros.Add(livro);
            _ctx.SaveChanges();
        }

        public void Atualizar(Livro livro)
        {
            _ctx.Livros.Update(livro);
            _ctx.SaveChanges();
        }



        public Livro BuscarId(int Id)
        {
            return _ctx.Livros.Include(i => i.Autores).FirstOrDefault(j=>j.Id.Equals(Id));
        }

        public Livro BuscarNome(string Nome)
        {
            return _ctx.Livros.Include(i => i.Autores).FirstOrDefault(j => j.Titulo.Equals(Nome));
        }

        public void Delete(Livro livro)
        {
            _ctx.Livros.Remove(livro);
        }

        public void SaveChanges()
        {
            _ctx.SaveChanges();
        }
    }
}
