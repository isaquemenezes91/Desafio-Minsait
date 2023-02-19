using Livraria.Models;


namespace Livraria.Manager.Interfaces
{
    public interface ILivroRepository
    {
        List<Livro> Buscar();
        Livro BuscarNome(string Nome);
        Livro BuscarId(int Id);
        void Adicionar(Livro livro);
        void Atualizar(Livro livro );

        void Delete(Livro livro);
        
    }

}
