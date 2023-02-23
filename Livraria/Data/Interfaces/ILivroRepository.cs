using Livraria.Models;


namespace Livraria.Manager.Interfaces
{
    public interface ILivroRepository
    {
        List<Livro> Buscar();
        Livro BuscarId(int Id);
        bool Adicionar(Livro livro);
        void Atualizar(Livro livro );

        void Delete(Livro livro);
        
    }

}
