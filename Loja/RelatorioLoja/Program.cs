using System;
using RelatorioLoja.GerenciarEstoque;
using RelatorioLoja.Manipular;
using RelatorioLoja.Fabrica;
using RelatorioLoja.Exibir;
using RelatorioLoja.Excecao;

namespace RelatorioLoja
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ManipuladorXML manipulador = new ManipuladorXML();
            manipulador.AnalisarArquivo("..\\..\\Sales_Stock.xml");
            var produtosEstoque = Estoque.ProdutosEstoque;

            int operacao = 1;
            while (!(operacao == 0))
            {
                MenuExibidor.Exibir();

                var processo = Console.ReadLine();
                if (!int.TryParse(processo, out operacao))
                {
                    operacao = SoliciarOperacaoNovamente(processo);
                }

                try
                {
                    Console.Clear();

                    var relatorio = FabricaTipoRelatorio.GerarTipoRelatorio(operacao);
                    var stringSerializada = relatorio.Serializar(produtosEstoque);
                    relatorio.GerarArquivo(stringSerializada);

                    var manipularJSON = new ManipuladorJSON();
                    manipularJSON.Apresentador(stringSerializada);
                }
                catch (OperacaoInvalidaException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public static int SoliciarOperacaoNovamente(string processo)
        {
            int operacao;
            while (!int.TryParse(processo, out operacao))
            {
                Console.Clear();
                Console.WriteLine("Operação invalida\n");
                MenuExibidor.Exibir();
                processo = Console.ReadLine();
            }
            return operacao;
        }
    }
}
