using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;


/// <summary>
/// /para funvionar temos que fazer algums passos primeiro vamos usar 
/// [EnableCors(origins: "*", headers: "*", methods: "*")]
/// depois vamos para tool /nuget / package manager console e coloca dentro do console do nuget : Install-Package Microsoft.AspNet.WebApi.Cors 
/// depois vamos no [EnableCors(origins: "*", headers: "*", methods: "*")] control punto e utilizar o Using cor que é o primeiro 
/// </summary>

namespace WebAPIWork.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CalculoImcController : ApiController
    {
        public string Get()
        {
            return "App para calcular o imc";
        }


        public string Get(double altura, double peso, string nomeUsuario)
        {


            double imc = (peso / (altura * altura));

            return $"ola {nomeUsuario} o numero {imc} é o teu IMC";
        }
    }
}



