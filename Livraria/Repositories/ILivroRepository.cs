using Livraria.Models;

namespace Livraria.Repositories
{
    public interface ILivroRepository
    {
        Task<IEnumerable<Livro>> GetAll();
        Task<Livro> Get(string Nome);
        Task<Livro> GetId(int Id);
        Task<Livro> Create(Livro livro);
        Task Update(Livro livro);

        Task Delete(int Id);
        
    }

}
