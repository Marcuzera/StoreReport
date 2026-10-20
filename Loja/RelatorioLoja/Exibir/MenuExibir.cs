using System;

namespace RelatorioLoja.Exibir
{
    /// <summary>
    /// Exibidor de menu de opções.
    /// </summary>
    public static class MenuExibidor
    {
        /// <summary>
        /// Opções referentes ao relatório que sera gerado.
        /// </summary>
        public static void Exibir()
        {
            Console.WriteLine("Digite a opção desejada: ");
            Console.WriteLine("1 - Quantidade de produtos em estoque ");
            Console.WriteLine("2 - Valor total de Venda dos produtos em estoque ");
            Console.WriteLine("3 - Produto mais vendido até o momento ");
            Console.WriteLine("4 - Produto mais rentável ");
            Console.WriteLine("5 - Produtos que não venderam ");
            Console.WriteLine("6 - Produtos que estão esgotados ");
            Console.WriteLine("7 - Todas as anteriores ");
            Console.WriteLine("0 - Sair ");
        }
    }
}
