using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Model;

namespace EntityClass.Controller
{
    public class AlunoController
    {
       ///Realizo minha conexao com o banco de dados
        EntityAlunosContextDB contextDB = new EntityAlunosContextDB();

        public
            IQueryable <Aluno> GetAlunos() 
        {
            return contextDB.ListaDeAlunos;
        }
        /// <summary>
        /// Metodo  para adicionar Pessoa no banco de Dados 
        /// </summary>
        /// <param name="item"></param>
        public void AddAlunos(Aluno item)
        {
            contextDB //Nosso banco de dados 
                .ListaDeAlunos //nossa tabela Pessoa 
                .Add(item); // Adicionamos o Item 

            contextDB.SaveChanges(); // Salvamos no banco 
        }
    }
}
