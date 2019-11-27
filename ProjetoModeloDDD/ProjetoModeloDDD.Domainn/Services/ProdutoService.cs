using System.Collections.Generic;
using ProjetoModeloDDD.Domainn.Entities;
using ProjetoModeloDDD.Domainn.Interfaces;
using ProjetoModeloDDD.Domainn.Interfaces.Services;

namespace ProjetoModeloDDD.Domainn.Services
{
    public class ProdutoService: ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository):base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepository.BuscarPorNome(nome);
        }
    }
}
