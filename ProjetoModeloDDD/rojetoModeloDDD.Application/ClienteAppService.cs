using System.Collections.Generic;
using ProjetoModeloDDD.Domainn.Entities;
using ProjetoModeloDDD.Domainn.Interfaces.Services;
using rojetoModeloDDD.Application.Interface;

namespace rojetoModeloDDD.Application
{
    public class ClienteAppService: AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService): base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> ObterClientesEspecias()
        {
            return _clienteService.ObterClientesEspeciais(_clienteService.GetAll());
        }
    }
}
