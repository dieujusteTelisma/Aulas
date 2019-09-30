using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
    public class SistemaCervejaContext
    {
        public int IdContadorCervejas { get; set; } = 1;
        /// <summary>
        /// Nossa massa de dados interna
        /// </summary>
        private List<Cerveja> ListaDeCervejas { get; set; }

        // <summary>
        /// Contrutor que prepara nossa massa de dados
        /// </summary>
        public SistemaCervejaContext()
        {
            //Criamos nossa lista de vendas em memoria
            //caso contrario ela fica null
            ListaDeCervejas = new List<Cerveja>();

            //Enfim meu primeiro registro
            ListaDeCervejas.Add(new Cerveja() { Id = IdContadorCervejas++, Nome = "Bramha", Litros = 4.50, Alcool = 5.20, Valor = 5.20 });
            ListaDeCervejas.Add(new Cerveja() { Id = IdContadorCervejas++, Nome = "Presidente", Litros = 5.50, Alcool = 4.30, Valor = 6.70 });
            ListaDeCervejas.Add(new Cerveja() { Id = IdContadorCervejas++, Nome = "Kaiser", Litros = 8.71, Alcool = 1.70, Valor = 7.70 });

            

        }
        /// <summary>
        /// Propriedade que contem as vendas realizadas sem nenhum tipo de filtro
        /// </summary>
        public List<Cerveja> ListaCervejasPublica { get { return ListaDeCervejas; } }

    }
}
