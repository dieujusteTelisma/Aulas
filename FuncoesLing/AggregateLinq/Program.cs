using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeNomes = new List<string>()
            {
                "Felipe",
                "GIomar",
                "Euricledson",
                "Adagoberto",
                "Ezebio",
                "Irineudson"
            };

            var texto = listaDeNomes
                //No Aggregate temos o nome atul que estamos lendo 
                //e o proximo nome da lista 
                .Aggregate((nome1, nome2) => nome1 + ";\r\n" + nome2);
                //No passo seguinte temos o ome proximo vira o atual
                //e pega o proximo da lista apos o atual 
            Console.WriteLine(texto);
            Console.ReadKey();
        }
    }
}
