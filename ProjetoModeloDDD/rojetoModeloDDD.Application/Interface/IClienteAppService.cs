using ProjetoModeloDDD.Domainn.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rojetoModeloDDD.Application.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspecias();
    }
}
