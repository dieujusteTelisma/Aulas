using System;

namespace UtilizandoFor
{
    class Program
    {
        static void Main(string[] args)
        {

            var nome = " meu nome é Felipe Junior e a minha mae escolheu colocar junior em meu nome porque achava legal";
            var countFind = 0;

            Console.WriteLine("Encontre a palavra de até 3 caracteres :");
            var palavra = Console.ReadLine();

            for (int i = 0; i < (nome.Length  -2) ; i++) // digitando for logo klike no rab duas vezes para criar todo o codigo
            {
                var palavraParaComparar = nome[i].ToString() +
                                          nome[i + 1].ToString() +
                                          nome[i + 2].ToString();
                if (palavraParaComparar.Contains(palavra))
                    countFind++;
                    
            }
            Console.WriteLine($"Quantidade total de '{palavra}'{countFind}");
            Console.ReadKey();

        }
    }
}

//var nome = "Webster Fever";

// for (int i = 0; i< 13; i++) // digitando for logo klike no rab duas vezes para criar todo o codigo
// {
//  Console.WriteLine(nome[i]);
// Console.WriteLine($"{nome[i - 1]} - {nome[i]} - {nome [i + 1]}");
//  }
//   Console.ReadKey();

//--------------------------------------------------------------
/*var nome = "WebsterFever";

         for (int i = 1; i< 11; i++) // digitando for logo klike no rab duas vezes para criar todo o codigo
           {
               Console.WriteLine($"{nome[i - 1]} - {nome[i]} - {nome [i + 1]}");
           }
           Console.ReadKey();*/



 //var nome = "FelipeJunior";
     //   var countFind = 0;

       // for (int i = 1; i < 11; i++) // digitando for logo klike no rab duas vezes para criar todo o codigo
       // {
        //    var stringBuilder = $"{nome[i - 1]} - {nome[i]} - {nome[i + 1]}";
         //   Console.WriteLine(stringBuilder);

       // if (stringBuilder.Contains("u-n"))
        //        countFind++;
       // }
      //  Console.WriteLine($"Quantidade total de 'un'{countFind}");
      //  Console.ReadKey();
 
