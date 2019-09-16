using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo que calcule e exiba o salário reajustado de dez funcionários de acordo com 
            // a seguinte regra: Salário até 300, reajuste de 50%; Salários maiores que 300, reajuste de 30%.

            Double salario = 0;
            Double salarioNovo = 0;
            Console.WriteLine("Efetua o reajuste salarial");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Informe o salário: ");
                salario = Convert.ToDouble(Console.ReadLine());
                if (salario <= 300)
                { //50%
                    salarioNovo = salario * 1.50;
                }
                else
                { //30%
                    salarioNovo = salario + ((salario * 30) / 100);
                }
                Console.WriteLine("Salário reajustado: " + salarioNovo);
            }
            Console.ReadKey();
        }
    }
}
