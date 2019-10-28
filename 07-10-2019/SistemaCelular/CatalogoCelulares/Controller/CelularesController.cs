using CatalogoCelulares.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Controller
{
    //1- usar nossa pasta model 'using catalogoCelular.model
    //2- criar uma instancia nova da nossa context

    //primeiro deixamos nossa classe publica
    public class CelularesController
    {
        CelularesContextDB contextDB = new CelularesContextDB();
        //Listagem
        /// <summary>
        /// Metodo que  retorna nossa lista de celulares ativos apenas 
        /// </summary>
        /// <returns>QueryList de celulares Filtrado por ativo</returns>

        public IQueryable<Celular> GetCelulars()
        {

            return contextDB // Nosso acesso ao banco de dados 
                .Celulares// nossa tabela do banco de dados 
                .Where//indicamos que vamos realizar um filtro 
                (x => x.Ativo == true); // as condicoes do filtro



        }
        //Atualizacao 
        /// <summary>
        /// Metodo que atualiza um registro valido do nosso sitema 
        /// </summary>
        /// <param name="item">Item que vamos atualizar </param>
        /// <returns>Retorna verdadeiro caso item exista</returns>
        public bool AtualizarCelular(Celular item)
        {
            var celular = //Definimos uma variavel para ocelular 

                contextDB//Usamos o banco de daodos 
                .Celulares // Nossa tabela que tem os celulares 
                .FirstOrDefault //Buscamos em nossa tabela o celular 
                (x => x.Id == item.Id); //Regra para realizar a busca 

            //falamos que nosso celular da tabela vai ser igual 
            //Nosso celualr que estamos passando 
            if (celular == null) // verifiscmos ele realmente encontrou um celular 
                return false;// caso nao tenha encontrado retornamos falso
            else
            {
               // celular = item; // Encontrou ele atualiza a informacao
                item.DataAlteracao = DateTime.Now; // Atualizamos 
                                                      //a data da alteracao do nosso celular 

            }



            contextDB.SaveChanges(); // salvamos a informacao no banco 

            return true;
        }
        //Insercao
        /// <summary>
        /// Metodo que valida e insere os registros dentro do sistema
        /// </summary>
        /// <param name="item">Nosso novo celular</param>
        /// <returns>Retorna verdadeiro para um item valido</returns>
        public bool InserirCelular(Celular item)
        {
            if (string //Nosso tipo que contem varios metodos prontos para string 
                .IsNullOrWhiteSpace //Metodo que identifica espacos em branco
                                    //apens ou valor 
                (item.Marca)) // Nosso campo que vamos validar 
                return false;

            if (string
                .IsNullOrWhiteSpace
                (item.Modelo))
                return false;

            if (item.Preco <= 0)// verificamos se o valor informado
                //é maior que 0
                return false; // caso nao ele ja retorna para fora do metodo

            //salvamos nosso item dentro da nossa tabela em memoria 
            contextDB.Celulares.Add(item);
            //salvamos agora no banco esta informacoa
            contextDB.SaveChanges();

            //retornamos verdadeiro para indicar sucesso na insercao do registro 
            return true;
        }
        //Remocao
        /// <summary>
        /// Metodo utilizado para apenas desativas o item dentro do noso sistema
        /// </summary>
        /// <param name="id">Id que vamos desaivar</param>
        /// <returns>Retorna verdadeiro em caso de sucesso!</returns>
        public bool RemoverCelular(int id)
        {
            var celular = // Nossa variavel
                 contextDB// nossa basa de dados 
                 .Celulares//Tabela de celular 
                 
                 .FirstOrDefault//buscamos o item para desativar
                 (x => x.Id == id);//informamos a regra de busca por id 

            if (celular == null) // verificamos se este item existe 
                return false;// caso nao ele sai de nosso metodo 
            celular.Ativo = false; // desativamos o item 
            contextDB.SaveChanges(); // salvamos em nosso banco 

            return true; // retornamos verdadeiro
        }


    }
}
