using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NetExo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elabore um algoritmo que calcule a idade média de 5 alunos.

            Double media = 0;
            Double idade1 = 0;
            Double idade2 = 0;
            Double idade3 = 0;
            Double idade4 = 0;
            Double idade5 = 0;
            Console.WriteLine("Programa que calcula a idade media de cinco alunos");
            Console.Write("Informe a idade do 1° alunos : ");
            idade1 = Double.Parse(Console.ReadLine());
            Console.Write("Informe a idade do 2° alunos : ");
            idade2 = Double.Parse(Console.ReadLine());
            Console.Write("Informe a idade do 3° alunos : ");
            idade3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a idade do 4° alunos : ");
            idade4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a idade do 5° alunos : ");
            idade5 = Convert.ToDouble(Console.ReadLine());
            media = (idade1 + idade2 + idade3 + idade4 + idade5) / 5;
            Console.WriteLine("A ídade média dos alunos é " + media);
            Console.ReadKey();
        }
    }
}
