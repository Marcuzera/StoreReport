using Newtonsoft.Json;
using RelatorioLoja.Extensao;
using RelatorioLoja.Interface;
using RelatorioLoja.Manipular;
using RelatorioLoja.Modelo;
using RelatorioLoja.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatorioLoja.Relatorio
{
    /// <summary>
    /// Responsavel pela operação referente ao relatório do total de vendas dos produtos em estoque.
    /// </summary>
    public class TotalVendaRelatorio : IRelatorio
    {
        /// <summary>
        ///  Faz a chamada do método GetTotalVenda.
        /// </summary>
        public ServicoVendas TotalVendaServico { get; set; }
        /// <summary>
        /// Construtor padrão da classe que instância o atributo.
        /// </summary>
        public TotalVendaRelatorio() => TotalVendaServico = new ServicoVendas();
        /// <summary>
        /// Serializa o total de vendas dos produtos em estoque.
        /// </summary>
        /// <param name="produtos">produtos que serão verificados.</param>
        /// <returns>Retorna a string serializada.</returns>
        public string Serializar(List<ProdutoModelo> produtos)
        {
            TotalVendaModelo totalVenda = new TotalVendaModelo(TotalVendaServico.GetTotalVenda(produtos));
            string estoque = JsonConvert.SerializeObject(totalVenda);
            return estoque;
        }
        /// <summary>
        /// Gera o arquivo serializado.
        /// </summary>
        /// <param name="json">String serializada.</param>
        public void GerarArquivo(string json)
        {
            ManipuladorJSON manipularJSON = new ManipuladorJSON();
            manipularJSON.CriarArquivo(json, "TotalVenda");
        }
    }
}
