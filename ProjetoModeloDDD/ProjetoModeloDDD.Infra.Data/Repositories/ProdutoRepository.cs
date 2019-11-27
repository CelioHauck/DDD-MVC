using ProjetoModeloDDD.Domainn.Entities;
using ProjetoModeloDDD.Domainn.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
            //var teste = Db.Produtos.Where(p => p.Nome == nome);
            //var total = teste.Count();

        }
    }
} 