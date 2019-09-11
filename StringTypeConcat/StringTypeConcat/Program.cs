using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTypeConcat
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var teste = @"alguma coisa mais alguma
             informacao aqui"; // com o @ na hora de quebra a linha nao aparece o sinak +

            var teste1 = Console.ReadLine();
            var teste2 = Console.ReadLine();
            //quebre a linha 

            var teste3 = teste1 + "\r\n" + teste2;
            Console.WriteLine(teste3);*/

            var testeTemplate = @"Nome do usuario:{0}
idade : {1}
Descricao : {2}
hummmm:{0}";

            var finishText = string.Format(testeTemplate
                , Console.ReadLine()
                , Console.ReadLine()
                , Console.ReadLine());

            Console.WriteLine(finishText);


          //  Console.WriteLine(teste);
            Console.ReadKey();
        }
    }
}
