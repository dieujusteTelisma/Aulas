using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessandoDllDoAmiguinho
{
    class Program
    {
        static void Main(string[] args)
        {
            var dllDoAmiginho = new MinhaBiblioteca.CalculosDeArea();
            Console.WriteLine(dllDoAmiginho.CalculaAreaDoQuadrado(3));

            Console.ReadKey();


            Console.ReadKey();
            

        }
    }
}
