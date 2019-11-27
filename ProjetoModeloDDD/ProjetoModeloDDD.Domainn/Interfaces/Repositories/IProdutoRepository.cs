using ProjetoModeloDDD.Domainn.Entities;
using System.Collections.Generic;
using ProjetoModeloDDD.Domainn.Interfaces.Repositories;

namespace ProjetoModeloDDD.Domainn.Interfaces
{
    public interface IProdutoRepository: IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
