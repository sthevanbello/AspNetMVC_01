using System.Collections.Generic;
using CasaDoCodigo;

namespace CasaDoCodigo.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Livro> livros);
    }
}