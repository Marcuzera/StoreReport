using Newtonsoft.Json;
using RelatorioLoja.Interface;
using RelatorioLoja.Manipular;
using RelatorioLoja.Modelo;
using RelatorioLoja.Servico;
using System.Collections.Generic;

namespace RelatorioLoja.Relatorio
{
    /// <summary>
    /// Responsavel pela operação referente ao relatório da quantidade de produto em estoque.
    /// </summary>
    public class QuantidadeEstoqueRelatorio : IRelatorio
    {
        /// <summary>
        /// Faz a chamada do método GetTotalEstoque.
        /// </summary>
        public ServicoEstoque ContadorTotalEstoque { get; set; }
        /// <summary>
        /// Construtor padrão da classe que instância o atributo.
        /// </summary>
        public QuantidadeEstoqueRelatorio() => ContadorTotalEstoque = new ServicoEstoque();
        /// <summary>
        /// Serializa a quantidade total de produtos em estoque.
        /// </summary>
        /// <param name="produtos">produtos que serão verificados.</param>
        /// <returns>Retorna a string serializada.</returns>
        public string Serializar(List<ProdutoModelo> produtos)
        {
            QntEstoqueModelo qntEstoque = new QntEstoqueModelo(ContadorTotalEstoque.GetTotalEstoque(produtos));
            string estoque = JsonConvert.SerializeObject(qntEstoque);
            return estoque;
        }
        /// <summary>
        /// Gera o arquivo serializado.
        /// </summary>
        /// <param name="json">String serializada.</param>
        public void GerarArquivo(string json)
        {
            ManipuladorJSON manipularJSON = new ManipuladorJSON();
            manipularJSON.CriarArquivo(json, "QuantidadeEstoque");
        }
    }
}
