using RelatorioLoja.Excecao;
using RelatorioLoja.Interface;
using RelatorioLoja.Relatorio;
using RelatorioLoja.Modelo.Enumeradores;

namespace RelatorioLoja.Fabrica
{
    /// <summary>
    /// Factory de relatórios.
    /// </summary>
    public static class FabricaTipoRelatorio
    {
        /// <summary>
        /// Gera o tipo do relatório solicitado.
        /// </summary>
        /// <param name="operacao">Operação do relatório escolhido.</param>
        /// <exception cref="OperacaoInvalidaException">Exceção lançada para valores de operação invalida.</exception>
        /// <returns>Instância do tipo IRelatorio</returns>
        public static IRelatorio GerarTipoRelatorio(int operacao)
        {
            var realtorio = (Factory)operacao;
                
            switch (realtorio)
            {
                case Factory.QuantidadeDeProdutosEmEstoque:
                    return new QuantidadeEstoqueRelatorio();

                case Factory.ValorTotalDeVenda:
                    return new TotalVendaRelatorio();

                case Factory.ProdutoMaisVendido:
                    return new MaisVendidoRelatorio();

                case Factory.ProdutoMaisRentavel:
                    return new MaiorVendaRelatorio();

                case Factory.ProdutosNaoVendidos:
                    return new NaoVendidoRelatorio();

                case Factory.ProdutosEsgotados:
                    return new EsgotadoRelatorio();

                case Factory.TodosRelatorios:
                    return new GeralRelatorio();

                default:
                    throw new OperacaoInvalidaException("Operação Invalida\n");
            }
        }
    }
}
