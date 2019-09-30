using ListagemDeCervejas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Controller
{
    public class CervejaController
    {
       
        SistemaCervejaContext cervejasContext = new SistemaCervejaContext();

        
        public void AdicionarCervejas(Cerveja parametroCerveja)
        {
            //Adicionamos a Cerveja em nossa lista.
            parametroCerveja.Id = cervejasContext.IdContadorCervejas++;
            cervejasContext.ListaCervejasPublica.Add(parametroCerveja);

        }
        
        /// <summary>
        /// Metodo que retorna a lista de Cerveja
        /// </summary>
        /// <returns>Lista de Cerveja</returns>
        public List<Cerveja> RetornaListaDeCerveja()
        {
            return cervejasContext.ListaCervejasPublica.Where(x => x.Ativo).ToList<Cerveja>();
        }        

        public List<Cerveja> GetCervejas()
        {
            return cervejasContext.ListaCervejasPublica;
          
        }

        public float getTotal()
        {
            var total = float.Parse(cervejasContext.ListaCervejasPublica.Sum(x => x.Valor).ToString());
            return total;
          
        }
      public float getTotalLItro()
        {
            var totalLitro = float.Parse(cervejasContext.ListaCervejasPublica.Sum(x => x.Litros).ToString());
            return totalLitro;
        }

        
    }
}
