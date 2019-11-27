using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoModeloDDD.Domainn.Entities;

namespace rojetoModeloDDD.Application.Interface
{
    public interface IProdutoAppService: IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
