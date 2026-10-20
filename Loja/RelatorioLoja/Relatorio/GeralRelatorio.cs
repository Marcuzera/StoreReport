using Newtonsoft.Json;
using RelatorioLoja.Interface;
using RelatorioLoja.Manipular;
using RelatorioLoja.Modelo;
using RelatorioLoja.Servico;
using System.Collections.Generic;

namespace RelatorioLoja.Relatorio
{
    /// <summary>
    /// Responsavel pela operação referente a todos relatórios de estoque.
    /// </summary>
    public class GeralRelatorio : IRelatorio
    {
        /// <summary>
        /// Faz a chamada do método ListEsgotados.
        /// </summary>
        public ServicoEstoque EsgotadoServico { get; set; }
        /// <summary>
        /// Faz a chamada do método GetTotalEstoque.
        /// </summary>
        public ServicoEstoque QuantidadeEstoqueServico { get; set; }
        /// <summary>
        /// Faz a chamada do método ListNaoVendidos.
        /// </summary>
        public ServicoVendas NaoVendidoServico { get; set; }
        /// <summary>
        ///  Faz a chamada do método GetMaisRentavel.
        /// </summary>
        public ServicoVendas MaiorVendaServico { get; set; }
        /// <summary>
        ///  Faz a chamada do método GetMaisVendido.
        /// </summary>
        public ServicoVendas MaisVendidoServico { get; set; }
        /// <summary>
        ///  Faz a chamada do método GetTotalVenda.
        /// </summary>
        public ServicoVendas TotalVendaServico { get; set; }
        /// <summary>
        /// Construtor padrão da classe que instância os atributos.
        /// </summary>
        public GeralRelatorio()
        {
            EsgotadoServico = new ServicoEstoque();
            QuantidadeEstoqueServico = new ServicoEstoque();
            NaoVendidoServico = new ServicoVendas();
            MaiorVendaServico = new ServicoVendas();
            MaisVendidoServico = new ServicoVendas();
            TotalVendaServico = new ServicoVendas();
        }
        /// <summary>
        /// Serializa todas operações de estoque.
        /// </summary>
        /// <param name="produtos">produtos que serão verificados.</param>
        /// <returns>Retorna a string serializada.</returns>
        public string Serializar(List<ProdutoModelo> produtos)
        {
            GeralModelo relatorio = new GeralModelo
            {
                Esgotados = EsgotadoServico.ListEsgotados(produtos),

                MaiorVenda = MaiorVendaServico.GetMaisRentavel(produtos),

                MaisVendido = MaisVendidoServico.GetMaisVendido(produtos),

                NaoVendido = NaoVendidoServico.ListNaoVendidos(produtos),

                QuantidadeEstoque = QuantidadeEstoqueServico.GetTotalEstoque(produtos),

                TotalVenda = TotalVendaServico.GetTotalVenda(produtos)
            };

            string estoque = JsonConvert.SerializeObject(relatorio);
            return estoque;
        }
        /// <summary>
        /// Gera o arquivo serializado.
        /// </summary>
        /// <param name="json">String serializada.</param>
        public void GerarArquivo(string json)
        {
            ManipuladorJSON manipularJSON = new ManipuladorJSON();
            manipularJSON.CriarArquivo(json, "Lista");
        }
    }
}
