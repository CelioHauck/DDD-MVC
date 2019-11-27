using System.Collections.Generic;
using ProjetoModeloDDD.Domainn.Entities;

namespace ProjetoModeloDDD.Domainn.Interfaces.Services
{
    public interface IClienteService: IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}
