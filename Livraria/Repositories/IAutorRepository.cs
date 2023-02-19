using Livraria.Models;

namespace Livraria.Repositories
{
    public interface ILivroRepository
    {
        Task<IEnumerable<Autor>> GetAll();
        Task<Autor> Get(string Nome);
        Task<Autor> GetId(int Id);
        Task<Autor> Create(Autor autor);
        Task Update(Autor autor);

        Task Delete(int Id);
        
    }

}
