using RelatorioLoja.GerenciarEstoque;
using RelatorioLoja.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatorioLoja.Servico
{
    /// <summary>
    /// Responsavel pelas operações dos produtos referentes a estoque.
    /// </summary>
    public class ServicoEstoque
    {
        /// <summary>
        /// Construtor padrão da classe.
        /// </summary>
        public ServicoEstoque()
        {
        }

        /// <summary>
        /// Verifica a quantidade de produtos em estoque.
        /// </summary>
        /// <param name="produtos">produtos que serão verificados.</param>
        /// <returns>Lista de produtos esgotados.</returns>
        public List<ProdutoModelo> ListEsgotados(List<ProdutoModelo> produtos)
        {
            List<ProdutoModelo> produtoEsgotado = new List<ProdutoModelo>();
            for (int i = 0; i < Estoque.ProdutosEstoque.Count; i++)
            {
                if (produtos[i].Estoque == 0)
                {
                    produtoEsgotado.Add(produtos[i]);
                }
            }
            return produtoEsgotado;
        }
        /// <summary>
        /// Verifica a quantidade de produtos em estoque.
        /// </summary>
        /// <param name="produtos">produtos que serão verificados.</param>
        /// <returns>Total dos produtos em estoque.</returns>
        public int GetTotalEstoque(List<ProdutoModelo> produtos)
        {
            int total = 0;
            for (int i = 0; i < Estoque.ProdutosEstoque.Count; i++)
            {
                total += produtos[i].Estoque;
            }

            return total;
        }
    }
}
