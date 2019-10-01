using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que leia a altura e a matricula de dez aluno. 
            //Mostre a matricula do aluno mais alto e do aluno mais baixo.

            String maMatricula;
            Double maAltura;

            String meMatricula;
            Double meAltura;

            String Matricula;
            Double Altura;

            Console.WriteLine("Determina o maior aluno e o menor aluno");
            Console.Write("Informe a matricula do aluno: ");
            Matricula = Console.ReadLine();
            Console.Write("Informe a altura do aluno: ");
            Altura = Convert.ToDouble(Console.ReadLine());

            maAltura = Altura;
            meAltura = Altura;
            maMatricula = Matricula;
            meMatricula = Matricula;
            int i = 1;
            while (i < 5)
            {
                Console.Write("Informe a matricula do aluno: ");
                Matricula = Console.ReadLine();
                Console.Write("Informe a altura do aluno: ");
                Altura = Convert.ToDouble(Console.ReadLine());
                if (maAltura < Altura)
                {
                    maMatricula = Matricula;
                    maAltura = Altura;
                }

                if (meAltura > Altura)
                {
                    meMatricula = Matricula;
                    meAltura = Altura;
                }
                i++;
            }
            Console.WriteLine("Maior aluno");
            Console.WriteLine("Matricula: {0}, Altura: {1}", maMatricula, maAltura);
            Console.WriteLine("Menor aluno");
            Console.WriteLine("Matricula: {0}, Altura: {1}", meMatricula, meAltura);
            Console.ReadKey();
        }
    }
}
