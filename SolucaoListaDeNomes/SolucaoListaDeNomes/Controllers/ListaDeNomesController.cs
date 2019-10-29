using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using SolucaoListaDeNomes.Models;


namespace SolucaoListaDeNomes.Controllers
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ListaDeNomesController : ApiController
    {
        //criamos nossalisata de objetos
        List<Pessoa> listaDePessoas = new List<Pessoa>()
             {
        new Pessoa(){Nome = "Felipe" , Idade = 35},
         new Pessoa(){Nome = "Web", Idade = 45},
           new Pessoa(){Nome = "CIlba", Idade = 23},
            new Pessoa(){Nome = "Webs", Idade = 12},
             new Pessoa(){Nome = "Oliv", Idade = 56},
              new Pessoa(){Nome = "Jean", Idade = 43},
               new Pessoa(){Nome = "Rivaldo", Idade = 28},
                new Pessoa(){Nome = "Marco", Idade = 16},
                 new Pessoa(){Nome = "Andrad", Idade = 23},
                  new Pessoa(){Nome = "River", Idade = 78},
        };
        public List<Pessoa> Get()
        {
            return listaDePessoas;
        }
        public string Get(int idade,string nome)
        {
            
          
            //Aqui temos o retorno do texto de acordo com a solicitação da questão
            return $"Olá {nome} sua Idade é {idade} ";
        }

        public List<Pessoa> Post(Pessoa values)
        {
            
            listaDePessoas.Add(values);
            return listaDePessoas.OrderByDescending(p => p.Idade).ToList();
           
        }
    }
}