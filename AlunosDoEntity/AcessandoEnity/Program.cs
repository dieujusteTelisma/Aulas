using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Controller;
using EntityClass.Model;

namespace AcessandoEnity
{
    class Program
    {
        static AlunoController aluno = new AlunoController();
        static void Main(string[] args)
        {
            aluno.AddAlunos(
                new Aluno()

                {

                    Nome = "Felipe",
                     Idade = 20
                });

            aluno.GetAlunos().ToList<Aluno>()
                           .ForEach(x => Console.WriteLine(x.Nome));
            Console.ReadKey();
        }
    }
}
