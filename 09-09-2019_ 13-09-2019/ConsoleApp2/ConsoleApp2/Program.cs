using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        //Iniciando uma constante de um numero inteiro
        const int testeConst = 999;
        
        static void Main(string[] args)
        {

            string testePrimitivo = string.Empty;
            String outroTestePrimitivo;

            bool testComp = "123" == "123";
            Boolean testeComp = "123" == "123";

            bool? testeBoolnull; // significa que vai ser null 

            int numeroInteiro = 999;
            long numeroInteiroLongo = 8598215;

            var testeFora = string.Empty;
            testeFora = "teste";
            var teste1 = "String"; //testo
            var teste2 = 'C'; //char
            var teste3 = 8; // int 
            var teste4 = 3.8; //double
            var teste5 = 0x0f; //hex 

            //Apresentando a const
            Console.WriteLine(testeConst);
            Console.ReadKey();
        }
    }
}
