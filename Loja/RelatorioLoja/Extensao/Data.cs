using System;
using System.Globalization;

namespace RelatorioLoja.Extensao
{
    /// <summary>
    /// Manipulador de datas.
    /// </summary>
    public static class Data
    {
        /// <summary>
        /// Converte string em DateTime.
        /// </summary>
        /// <param name="dataModificacao">Data a ser modificada.</param>
        /// <returns></returns>
        public static DateTime ConverterData(this string dataModificacao)
        {
            string format = "yyyyMMddTHHmmss";
            CultureInfo provider = CultureInfo.InvariantCulture;
            var dateTime = (DateTime.ParseExact(dataModificacao, format, provider));

            return dateTime;
        }
    }
}
