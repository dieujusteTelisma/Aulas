using InsercaoDeinformacoesDeUma.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InsercaoDeinformacoesDeUma.Controller
{
    public class FloreController
    {
        FloreContextDB contextDB = new FloreContextDB();
        public IQueryable<Flore> GetFlore()
        {

            return contextDB // Nosso acesso ao banco de dados 
                .ListaDeFlores// nossa tabela do banco de dados 
                .Where//indicamos que vamos realizar um filtro 
                (x => x.Ativo == true); // as condicoes do filtro

        }


        public bool InsertFlor(Flore item)
        {
            if (string //Nosso tipo que contem varios metodos prontos para string 
                .IsNullOrWhiteSpace //Metodo que identifica espacos em branco
                                    //apens ou valor 
                (item.Nome)) // Nosso campo que vamos validar 
                return false;



            if (item.Quantidade <= 0)// verificamos se o valor informado
                                     //é maior que 0
                return false; // caso nao ele ja retorna para fora do metodo

            //salvamos nosso item dentro da nossa tabela em memoria 
            contextDB.ListaDeFlores.Add(item);
            //salvamos agora no banco esta informacoa
            contextDB.SaveChanges();

            //retornamos verdadeiro para indicar sucesso na insercao do registro 
            return true;
        }
    }
}

