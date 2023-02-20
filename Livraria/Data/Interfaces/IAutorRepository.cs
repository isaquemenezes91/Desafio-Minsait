using Livraria.Models;

namespace Livraria.Data.Interfaces
{
    public interface IAutorRepository
    {
     
        Autor BuscarIdAutor(int Id);
        void AdicionarAutor(Autor autor);
        void AtualizarAutor(Autor autor);

        void DeleteAutor(Autor autor);
    }
}
