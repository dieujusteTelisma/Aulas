using ListagemDeNomes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeNomes.Controller
{
    public class NomeController

    {
        //Realizo minha conexao com o banco de dados 
        ListagemContextDB contextDB = new ListagemContextDB();

        public
            IQueryable<Nomes> GetNome()
        {
            return contextDB.ListaDeNome;
        }

        public void AddNome(Nomes item)
        {
            contextDB.ListaDeNome.Add(item);

            contextDB.SaveChanges(); // Salvamos no banco 
        }
    }
}
