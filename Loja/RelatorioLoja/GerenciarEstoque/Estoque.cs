using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RelatorioLoja.Extensao;
using RelatorioLoja.Modelo;

namespace RelatorioLoja.GerenciarEstoque
{
    /// <summary>
    /// Armazem dos produtos.
    /// </summary>
    public static class Estoque
    {
        /// <summary>
        /// Lista dos produtos.
        /// </summary>
        public static List<ProdutoModelo> ProdutosEstoque = new List<ProdutoModelo>();
        /// <summary>
        /// Adiciona os produtos no estoque.
        /// </summary>
        /// <param name="novoProduto">Produto inserido no estoque.</param>
        public static void AdicionarProduto(ProdutoModelo novoProduto)
        {
            if (AutenticarProduto(novoProduto))
            {
                ProdutosEstoque.Add(novoProduto);
            }
        }
        /// <summary>
        /// Verifica se o novo produto inserido é repetido.
        /// </summary>
        /// <param name="novoProduto">Produto a ser verificado.</param>
        /// <returns>Falso se for repetido e mais antigo que o que está na lista, caso contrario retorna verdadeiro.</returns>
        internal static bool AutenticarProduto(ProdutoModelo novoProduto)
        {
            for (int i = (ProdutosEstoque.Count - 1); i >= 0; i--)
            {
                if (ProdutosEstoque[i].Id.Contains(novoProduto.Id))
                {
                    string stringNovoProduto = novoProduto.DataModificacao.ToString();
                    string stringProduto = ProdutosEstoque[i].DataModificacao.ToString();
                    if (Data.ConverterData(stringProduto) < Data.ConverterData(stringNovoProduto))
                    {
                        RemoverItem(i);
                        return true;
                    }
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Insere os valores do produto.
        /// </summary>
        /// <param name="Id">Id do produto.</param>
        /// <param name="Nome">Nome do do produto.</param>
        /// <param name="Descricao">Descrição do produto.</param>
        /// <param name="Preco">Preco do produto.</param>
        /// <param name="QuantidadeEstoque">Quantida disponivel em estoque do produto.</param>
        /// <param name="QntVendas">Quantidade de vendas do produto.</param>
        /// <param name="DataModificacao">Data de modificação do produto.</param>
        public static void AtribuirValores(string Id, string Nome,
            string Descricao, double Preco, int QuantidadeEstoque,
            int QntVendas, string DataModificacao)
        {

            ProdutoModelo produto = new ProdutoModelo(Id, Nome, Descricao, Preco,
                QuantidadeEstoque, QntVendas, DataModificacao);

            AdicionarProduto(produto);

        }
        /// <summary>
        /// Remove item do estoque.
        /// </summary>
        /// <param name="index">indice do produto que sera removido.</param>
        public static void RemoverItem(int index)
        {
            ProdutosEstoque.RemoveAt(index);
        }
    }
}
