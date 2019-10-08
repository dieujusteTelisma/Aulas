using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstTeste.Controller;
using CodeFirstTeste.Model;

namespace GambCodeFirst
{
    class Program
    {
        //1- setar a aplicacao visual para startar o projeto 
        //2- vamos adicionar EntityFramework ao nosso projeto console pelo tools
        //3-Colocar em nosso Using o system.Data.Entity
        //4- Adicionar a referencia da nossa ClassLIbrary

        // static CervejaContextDB Cerveja = new CervejaContextDB();
        static CervejaController cerveja = new CervejaController();
        static void Main(string[] args)
        {

            cerveja.AddCerveja(new Cerveja() { Nome = "Cerveja Weiser" });

            cerveja.GetCervejas().ToList<Cerveja>()
                   .ForEach(x => Console.WriteLine(x.Nome));

            Console.ReadKey();
        }
    }
}