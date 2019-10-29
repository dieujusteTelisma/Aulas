using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiBancoExistente.Models;



// vamos criar um banco de dados para nossa applicacao vamos peggar um banco existente 
// vamos pegar obanco de dadosinner join 
// primeiro vamos na pasta model add depois escolher new item depois data escolhe Ado.net empty depois code first from database 
//Vamos clicar no new connection depois escrevemos no server name (localdb)\MSQLLOCALDB e no campo select data base vamos selecionar nosso 
//data baser innerjoind depois vamos cliar no OK e Depois clicar no teste conection Depois ok , next  e selecionar todo 
//Depois finsish  vai aparecer todoa as tabelas Depois vamos criar a pasta controlle. 
//a criacao da pasta controller é igual que ja criamos na SitemaPessoaWebAPI

// depois vamos na pasta golbal.asax para colocar :

/*
 GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings
.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        GlobalConfiguration.Configuration.Formatters
            .Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);

 */

//depos vamos no carro e colocar [JsonIgnore] // ignoramos Marca1 para sereliarizar  nosso objeto // sim isso os dados nao vao aparecer muito legal 
//tambem vai reduzri o Kbites para aparecer melhor no Postman antes era 576 KB agora é 18KB. podemos usar o ignore para diminuir 




namespace WebApiBancoExistente.Controllers
{
    public class CarroesController : ApiController
    {
        private DataBaseContext db = new DataBaseContext();


        [HttpGet]
        [Route("Api/Carroes/CustomQuery")]
        public object CustomCarrosQuery()
        {
            var listaDeCarros = db.Carros.ToList();
            var retornoCarros = from cr in listaDeCarros
                                select new {
                                NomeCarro = cr.Modelo,
                                carroId = cr.Id
                                };
            return retornoCarros;
        }
        [HttpGet]
        [Route("Api/Carroes/CarrosComMarcas")]
        public object CustomCarrosOnMarcas()
        {
            var listCarros = db.Carros.ToList();
            var listMarcas = db.Marcas.ToList();

            var conteudoRetorno = from mar in listMarcas
                                  join car in listCarros
                                  on mar.Id equals car.Marca
                                  select new
                                  {
                                      CarroId = car.Id,
                                      CarroNome = car.Modelo,
                                      MarcaId = mar.Id,
                                      MarcaNome = mar.Nome

                                  };
            return conteudoRetorno;

        }

        // GET: api/Carroes
        public IQueryable<Carro> GetCarros()
        {
            return db.Carros;
        }

        // GET: api/Carroes/5
        [ResponseType(typeof(Carro))]
        public IHttpActionResult GetCarro(int id)
        {
            Carro carro = db.Carros.Find(id);
            if (carro == null)
            {
                return NotFound();
            }

            return Ok(carro);
        }

        // PUT: api/Carroes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCarro(int id, Carro carro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != carro.Id)
            {
                return BadRequest();
            }

            db.Entry(carro).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarroExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Carroes
        [ResponseType(typeof(Carro))]
        public IHttpActionResult PostCarro(Carro carro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Carros.Add(carro);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = carro.Id }, carro);
        }

        // DELETE: api/Carroes/5
        [ResponseType(typeof(Carro))]
        public IHttpActionResult DeleteCarro(int id)
        {
            Carro carro = db.Carros.Find(id);
            if (carro == null)
            {
                return NotFound();
            }

            db.Carros.Remove(carro);
            db.SaveChanges();

            return Ok(carro);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CarroExists(int id)
        {
            return db.Carros.Count(e => e.Id == id) > 0;
        }
    }
}