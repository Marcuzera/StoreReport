namespace RelatorioLoja.Modelo
{
    /// <summary>
    /// Modelo para operação referente ao total de vendas dos produtos em estoque.
    /// </summary>
    public class TotalVendaModelo : RelatorioEstoqueModelo
    {
        /// <summary>
        /// Total de vendas dos produtos em estoque.
        /// </summary>
        public double TotalEmVendas;
        /// <summary>
        /// Inicializa o atributo da classe.
        /// </summary>
        /// <param name="totalVenda">Valor total de vendas.</param>
        public TotalVendaModelo(double totalVenda)
        {
            TotalEmVendas = totalVenda;
        }
    }
}
