using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class ShowList
    {
        public static void ListaString()

        {
            var minhaLista = new List<string>();

            minhaLista.Add("Skoll");
            minhaLista.Add("Brahma");
            minhaLista.Add("Itaipava");
            minhaLista.Add("Kaiser");
            minhaLista.ForEach(i => Console.WriteLine(i)); // i  significa item da lista 


        }

    }
}
