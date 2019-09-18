using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class ListCar
    {
        public static void ListaCar()

        {
            var minhaLista = new List<string>();

            minhaLista.Add("Toyota");
            minhaLista.Add("Ferrari");
            minhaLista.Add("Lamboghini");
            minhaLista.Add("Jeep");
            minhaLista.ForEach(i => Console.WriteLine(i)); // i  significa item da lista 


        }
    }
}
