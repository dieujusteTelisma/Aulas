﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos.
            //O algoritmo deverá ler a idade de 10 pessoas.

            int qtde = 0;
            int idade = 0;
            Console.WriteLine("Exercício 2 - Verifica maior idade");
            int i = 0;
            while (i < 10)
            {
                i = i + 1;
                Console.Write("Informe a idade da pessoa: ");
                idade = Convert.ToInt32(Console.ReadLine());
                if (idade >= 18)
                {
                    qtde = qtde + 1;
                }
            }
            Console.WriteLine("Existem " + qtde + " pessoas com mais de 18 anos");
            Console.ReadKey();
        }
    }
}
