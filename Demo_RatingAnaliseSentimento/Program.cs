using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_RatingAnaliseSentimento
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://brazilsouth.api.cognitive.microsoft.com/text/analytics/v2.0
            Console.WriteLine("Entre com o texto positivo ou negativo");
            var texto = Console.Read();
            var sentimentServices = SentimentService.GetSentiment(texto.ToString());
            Console.WriteLine(sentimentServices.Result);

            //Console.WriteLine("Entre com o texto negativo");
            //var textoNegativo = Console.Read();
            //var sentimentServicesNegativo = SentimentService.GetSentiment(textoNegativo.ToString());
            //Console.WriteLine(sentimentServicesNegativo.Result);

            Console.ReadKey();
        }
    }
}
