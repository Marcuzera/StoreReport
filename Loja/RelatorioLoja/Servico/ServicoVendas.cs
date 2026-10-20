using RelatorioLoja.Extensao;
using RelatorioLoja.GerenciarEstoque;
using System;
using System.Collections.Generic;

namespace RelatorioLoja.Servico
{
    /// <summary>
    /// Responsavel pelas operações dos produtos referentes a vendas.
    /// </summary>
    public class ServicoVendas
    {
        public ServicoVendas()
        {

        }
        /// <summary>
        /// Verifica a quantidade de vendas do produto.
        /// </summary>
        /// <param name="produtos">produtos que serão verificados.</param>
        /// <returns>Lista dos produtos não vendidos.</returns>
        public List<ProdutoModelo> ListNaoVendidos(List<ProdutoModelo> produtos)
        {
            List<ProdutoModelo> objetoNaoVendido = new List<ProdutoModelo>();
            for (int i = 0; i < Estoque.ProdutosEstoque.Count; i++)
            {
                if (produtos[i].QntVendas == 0)
                {
                    objetoNaoVendido.Add(produtos[i]);
                }
            }
            return objetoNaoVendido;
        }
        /// <summary>
        /// Verifica a quantidade de vendas do produto.
        /// </summary>
        /// <param name="produtos">produtos que serão verificados.</param>
        /// <returns>O produto mais vendido.</returns>
        public ProdutoModelo GetMaisVendido(List<ProdutoModelo> produtos)
        {
            ProdutoModelo maisVendido = null;

            for (int i = 0; i < Estoque.ProdutosEstoque.Count; i++)
            {
                if (i == 0)
                {
                    maisVendido = produtos[i];
                }
                else if (produtos[i].QntVendas > maisVendido.QntVendas)
                {
                    maisVendido = produtos[i];
                }
                else if (produtos[i].QntVendas == maisVendido.QntVendas)
                {
                    DateTime dataProdutoAtual = Data.ConverterData(produtos[i].DataModificacao);
                    DateTime data = Data.ConverterData(maisVendido.DataModificacao);
                    if (data < dataProdutoAtual)
                    {
                        maisVendido = produtos[i];
                    }
                }
            }
            return maisVendido;
        }
        /// <summary>
        /// Verifica o valor de total de venda dos produtos.
        /// </summary>
        /// <param name="produtos">produtos que serão verificados.</param>
        /// <returns>O produto de mais rentavel.</returns>
        public ProdutoModelo GetMaisRentavel(List<ProdutoModelo> produtos)
        {
            double _totalMaisRentavel = 0;
            ProdutoModelo _produtoMaisRentavel = null;

            for (int i = 0; i < Estoque.ProdutosEstoque.Count; i++)
            {
                double aux = produtos[i].Preco * produtos[i].QntVendas;
                if (_totalMaisRentavel < aux)
                {
                    _produtoMaisRentavel = produtos[i];
                    _totalMaisRentavel = aux;
                }
                else if (_totalMaisRentavel == aux)
                {
                    DateTime dataProdutoAtual = Data.ConverterData(produtos[i].DataModificacao);
                    DateTime data = Data.ConverterData(_produtoMaisRentavel.DataModificacao);
                    if (data < dataProdutoAtual)
                    {
                        _produtoMaisRentavel = produtos[i];
                        _totalMaisRentavel = aux;
                    }
                }
            }

            return _produtoMaisRentavel;
        }
        /// <summary>
        /// Soma o valor total de venda de cada produto.
        /// </summary>
        /// <param name="produtos">produtos que serão verificados.</param>
        /// <returns>O valor total de vendas.</returns>
        public double GetTotalVenda(List<ProdutoModelo> produtos)
        {
            double totalVendas = 0;
            for (int i = 0; i < Estoque.ProdutosEstoque.Count; i++)
            {
                totalVendas += produtos[i].Preco * produtos[i].QntVendas;
            }

            return Math.Round(totalVendas, 2);
        }
    }
}
