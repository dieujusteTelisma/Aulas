using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RevisandoEntity.Model;
using RevisandoEntity.Controller;



namespace AplicacaoVisual
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
            /*  Cerveja.Cervejas.Add(new RevisandoEntity.Model.Cerveja() { Nome = "Golimar" });
             Cerveja.SaveChanges();
                  Cerveja.Cervejas.ToList<Cerveja>()
                  .ForEach(x => Console.WriteLine(x.Nome)); */

            cerveja.AddCerveja(new Cerveja() {Nome = "Cerveja Skol" });

            cerveja.GetCervejas().ToList<Cerveja>()
                   .ForEach(x => Console.WriteLine(x.Nome));

            Console.ReadKey();
        }
    }
}
