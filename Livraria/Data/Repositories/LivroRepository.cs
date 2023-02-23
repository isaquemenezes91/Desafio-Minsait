using Livraria.Data.Context;
using Livraria.Manager.Interfaces;
using Livraria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Data.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private LivrariaContext _ctx;
        private readonly LogErroRepository _logRepository;
        private readonly string erroBadRequest = "Ocorreu uma falha interna, favor tente novamente mais tarde ou procure um dos nossos suportes!";

       
        public LivroRepository(LivrariaContext ctx)
        {
            _ctx = ctx;
            _logRepository = new(ctx);
        }

        public List<Livro> Buscar()
        {
            return _ctx.Livros.Include(i=>i.Autores).ToList();
        }

        public bool Adicionar(Livro livro)
        {
            
                Livro validation1 = _ctx.Livros.Include(i => i.Autores).FirstOrDefault(j => j.Titulo.Equals(livro.Titulo));

                if (validation1 != null && validation1.Edicao == livro.Edicao && validation1.Subtitulo == livro.Subtitulo)
                {
                    return true;
                }

                _ctx.Livros.Add(livro);
                _ctx.SaveChanges();
                return false;

            
            
        }

        public void Atualizar(Livro livro)
        {
            _ctx.Livros.Update(livro);
            _ctx.SaveChanges();
        }



        public  Livro BuscarId(int Id)
        {
            Livro retorno = new();
            retorno =  _ctx.Livros.Include(i => i.Autores).FirstOrDefault(j => j.Id.Equals(Id));
            return retorno;
        }


        public void Delete(Livro livro)
        {
            _ctx.Livros.Remove(livro);
        }
        public void RemoverAutores(List<Autor> autores)
        {
            _ctx.Autores.RemoveRange(autores);
        }
        public void SaveChanges()
        {
            _ctx.SaveChanges();
        }
    }
}
