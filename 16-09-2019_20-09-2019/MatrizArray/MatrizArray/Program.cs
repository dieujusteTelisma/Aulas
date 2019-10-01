using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] arrayLinear = new string[3] { " Felipe ", "Webster", "Helene" };

            string[] arrayLinear = new string[2];
                
            arrayLinear[0] = "Felipe";
            arrayLinear[1] = "Webster";

            List<string> listalinear = new List<string>
            {
                "Felipe",
                "Webster",
                "Helene"
            };

            Console.WriteLine(arrayLinear[0]);
            Console.WriteLine(listalinear[0]);

            // qualquer botao que aperta ele encerra 
            var keypress = Console.ReadKey();
        }
    }
}
