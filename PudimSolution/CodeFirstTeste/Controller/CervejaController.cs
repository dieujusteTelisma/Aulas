using CodeFirstTeste.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeFirstTeste.Controller
{
    public class CervejaController
    {
        //iniciamos nossa base de dados na controller 
        CervejaContextDb contextDB =
            new CervejaContextDb(@"data source=(localdb)\MSSQLLocalDB;initial catalog=RevisandoEntity.Model.CervejaContextDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        public void AddCerveja(Cerveja item)
        {
            if (item.Nome.Contains("Cerveja"))
            {
                contextDB.Cervejas.Add(item);
                contextDB.SaveChanges();
            }


        }

        public IQueryable<Cerveja> GetCervejas()
        {
            return contextDB
                .Cervejas
                .Where(x => x.Nome.Contains("Cerveja"));
        }
    }
}




















