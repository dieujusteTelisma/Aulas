using PutBicicletas.Model;
using PutBicicletas.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutBicicletas.Controller
{
    public class BicicletasController
    {
        BicicletaContextDB contextDB = new BicicletaContextDB();

        public IQueryable<Bicicleta> GetBicicletas()

        {

            return contextDB.Bicicletas.Where(x => x.Ativo == true);



        }

        public bool AtualizarBicicleta(Bicicleta item)

        {

            var bicicleta =

            contextDB.Bicicletas.FirstOrDefault(x => x.Id == item.Id);

            if (bicicleta == null)

                return false;

            else

            {

                item.DataAlteracao = DateTime.Now;

            }

            contextDB.SaveChanges();

            return true;


        }

        //Insercao

        /// <summary>

        /// Metodo que valida e insere os registros dentro do sistema

        /// </summary>

        /// <param name="item">Nosso novo celular</param>

        /// <returns>Retorna verdadeiro para um item valido</returns>

        public bool InserirBicicleta(Bicicleta item)

        {

            if (string.IsNullOrWhiteSpace(item.Marca))

                return false;



            if (string

                .IsNullOrWhiteSpace

                (item.Modelo))

                return false;



            if (item.Preco <= 0)



                return false;



            //salvamos nosso item dentro da nossa tabela em memoria 

            contextDB.Bicicletas.Add(item);

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

        public bool RemoverBicicleta(int id)

        {

            var bicicleta = // Nossa variavel

                 contextDB// nossa basa de dados 

                 .Bicicletas//Tabela de celular 



                 .FirstOrDefault//buscamos o item para desativar

                 (x => x.Id == id);//informamos a regra de busca por id 



            if (bicicleta == null) // verificamos se este item existe 

                return false;// caso nao ele sai de nosso metodo 

            bicicleta.Ativo = false; // desativamos o item 

            contextDB.SaveChanges(); // salvamos em nosso banco 



            return true; // retornamos verdadeiro

        }
    }

}  
