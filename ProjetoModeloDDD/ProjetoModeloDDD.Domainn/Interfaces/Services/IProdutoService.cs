using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoModeloDDD.Domainn.Entities;

namespace ProjetoModeloDDD.Domainn.Interfaces.Services
{
    public interface IProdutoService: IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
