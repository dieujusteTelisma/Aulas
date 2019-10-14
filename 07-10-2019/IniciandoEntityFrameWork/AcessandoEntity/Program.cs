using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Controller;
using EntityClass.Model;

namespace AcessandoEntity
{
    class Program
    {
        static PessoaController pessoa = new PessoaController();
        static void Main(string[] args)
        {
            pessoa.AddPessoa( // Aqui utilizamos o metodo da controller para 
                new Pessoa()//Adicionar a pessoa em nossa lista 

                { 

                 Nome =  "Felipe"// Novo registro 
               
                 }); // o metodo Addpessoa tem o SaveChanges que realiza a gravacao 
            //das informacoes em nosso banco de dados 

                               
            pessoa.GetPessoas() // obtemos a lista de pessoas 
                .ToList<Pessoa>() // convertemos para uma lista de pessos 
                .ForEach(x => Console.WriteLine(x.Nome)); // mostramos em nosso console
            Console.ReadKey();
        }
    }
}
