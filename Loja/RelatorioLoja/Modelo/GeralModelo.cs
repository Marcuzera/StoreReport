using System.Collections.Generic;

namespace RelatorioLoja.Modelo
{
    /// <summary>
    /// Modelo para relatório de todas operações de estoque.
    /// </summary>
    public class GeralModelo : RelatorioEstoqueModelo
    {
        /// <summary>
        /// Quantidade total de estoque.
        /// </summary>
        public int QuantidadeEstoque { get; set; }
        /// <summary>
        /// Total de vendas dos produtos de estoque.
        /// </summary>
        public double TotalVenda { get; set; }
        /// <summary>
        /// Produtos do estoque que estão esgotados.
        /// </summary>
        public List<ProdutoModelo> Esgotados{ get; set; }
        /// <summary>
        /// Produto mais rentavel do estoque.
        /// </summary>
        public ProdutoModelo MaiorVenda { get; set; }
        /// <summary>
        /// Produto mais vendido do estoque.
        /// </summary>
        public ProdutoModelo MaisVendido { get; set; }
        /// <summary>
        /// Produtos do estoque que não venderam.
        /// </summary>
        public List<ProdutoModelo> NaoVendido { get; set; }
        
    }
}
