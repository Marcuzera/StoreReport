namespace RelatorioLoja.Modelo
{
    /// <summary>
    /// Modelo para operação referente ao total de produtos em estoque.
    /// </summary>
    public class QntEstoqueModelo : RelatorioEstoqueModelo
    {
        /// <summary>
        /// Quantidade total dos produtos em estoque.
        /// </summary>
        public int QuantidadeEmEstoque { get; set; }
        /// <summary>
        /// Inicializa o atributo da classe.
        /// </summary>
        /// <param name="quantidadeEstoque">Total em estoque.</param>
        public QntEstoqueModelo(int quantidadeEstoque)
        {
            QuantidadeEmEstoque = quantidadeEstoque;
        }
    }
}
