using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculandoIdade.Controllers
{
    public class CalculoIdadeController : ApiController
    {



        /// <summary>
        /// Retorna nome da aplicacao eo que ela faz 
        /// </summary>
        /// <returns></returns>
        public string Get()
        {
            return "App para poder beber hoje";
        }

        public string Get(int anoNascimento , string nomeUsuario)
        {
            string retono = "nada ocorreu";
            if((DateTime.Now.Year - anoNascimento) >= 18)
            {
                return $" ola {nomeUsuario} voce pode beber cerveza Nada ocorreu";
            }
            else
            {
                return $" ola {nomeUsuario} voce nao pode beber cerveza Nada ocorreu";
            }
        }
    }
}
