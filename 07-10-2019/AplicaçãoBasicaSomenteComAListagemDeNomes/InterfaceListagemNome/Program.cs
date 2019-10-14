using ListagemDeNomes.Controller;
using ListagemDeNomes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceListagemNome
{
    class Program
    {
        static NomeController nome = new NomeController();
        static void Main(string[] args)
        {
            nome.AddNome(new Nomes(){ Nome = "Felipe"});
            nome.AddNome(new Nomes() { Nome = "Webster" });
            nome.AddNome(new Nomes() { Nome = "Jean" });
            nome.AddNome(new Nomes() { Nome = "Jhon" });


 nome.GetNome()
                .ToList<Nomes>()
                .ForEach(x => Console.WriteLine(x.Nome));
            Console.ReadKey();

        }
    }
}
