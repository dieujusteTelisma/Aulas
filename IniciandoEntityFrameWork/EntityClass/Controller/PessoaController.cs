using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Model;

namespace EntityClass.Controller
{
   public class PessoaController
    {
        //Realizo minha conexao com o banco de dados 
        EntityContextDB contextDB = new EntityContextDB();

        public 
            IQueryable// aqui temos nossa primeira interface com a classe 
            //Iqueryable essa classe contem varios funcionalidades
            //prontas para usar igual ao banco de dados com os selects 
            <Pessoa> //definmos o tipo que ira retornar 
            GetPessoas() //damos um nme ao nosso metodo
        {
            return contextDB.ListaDePessoas;
        }
        /// <summary>
        /// Metodo  para adicionar Pessoa no banco de Dados 
        /// </summary>
        /// <param name="item"></param>
        public void AddPessoa(Pessoa item)
        {
            contextDB //Nosso banco de dados 
                .ListaDePessoas //nossa tabela Pessoa 
                .Add(item); // Adicionamos o Item 

            contextDB.SaveChanges(); // Salvamos no banco 
        }
    }
}
