using Newtonsoft.Json;
using System;
using System.IO;

namespace RelatorioLoja.Manipular
{
    /// <summary>
    /// Reponsavel pelas ações dos arquivos de extensão json.
    /// </summary>
    public class ManipuladorJSON
    {
        /// <summary>
        /// Cria um novo arquivo json.
        /// </summary>
        /// <param name="json">Conteúdo do arquivo que sera criado.</param>
        /// <param name="nome">Nome do arquivo.</param>
        public void CriarArquivo(string json, string nome)
        {
            string arquivo = nome + ".json";

            try
            {
                using (StreamWriter fs = File.CreateText(arquivo))
                {
                    JsonSerializer serializar = new JsonSerializer();
                    serializar.Serialize(fs, json);

                    Console.WriteLine("\nArquivo Criado com Sucesso\n");
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel criar o arquivo");
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Leitor de arquivo json.
        /// </summary>
        /// <param name="json">String que será lida.</param>
        public void Apresentador(string json)
        {
            try
            {
                var deserialize = JsonConvert.DeserializeObject<object>(json);
                Console.WriteLine(deserialize);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel ler o arquivo");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
