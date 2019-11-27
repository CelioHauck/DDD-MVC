﻿using ProjetoModeloDDD.Domainn.Entities;
using ProjetoModeloDDD.Domainn.Interfaces;
using ProjetoModeloDDD.Domainn.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Domainn.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
   {
       private readonly IClienteRepository _clienteRepository;

       public ClienteService(IClienteRepository clienteRepository):base(clienteRepository)
       {
           _clienteRepository = clienteRepository;
       }

        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}
