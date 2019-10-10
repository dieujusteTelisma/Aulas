using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
   
    public class LivrosController
    {
        LocacaoContext contextDB = new LocacaoContext();
       

        public IQueryable<Livro> GetLivros()
        {
            
            return contextDB.Livros.Where(x => x.Ativo == true);
        }

        public void AddLivro(Livro item)
        {
            
            contextDB.Livros.Add(item);
           
            contextDB.SaveChanges();

        }

       
        public bool AtualizarLivro(Livro item)
        {
            var livro = //Definimos uma variavel para livro 

                contextDB//Usamos o banco de daodos 
                .Livros // 
                .FirstOrDefault //Buscamos em nossa tabela do livro 
                (x => x.Id == item.Id); //Regra para realizar a busca 

            //falamos que nosso livro da tabela vai ser igual 
            //Nosso livro que estamos passando 
            if (livro == null) 

                return false;// caso nao tenha encontrado retornamos falso
            else
            {
                // celular = item; // Encontrou ele atualiza a informacao
                item.DataAlteracao = DateTime.Now; 
                                                   

            }



            contextDB.SaveChanges(); // salvamos a informacao no banco 

            return true;
        }
        public bool InserirLivro(Livro item)
        {
            if (string //Nosso tipo que contem varios metodos prontos para string 
                .IsNullOrWhiteSpace //Metodo que identifica espacos em branco
                                    //apens ou valor 
                (item.Nome)) // Nosso campo que vamos validar 
                return false;

            if (string
                .IsNullOrWhiteSpace
                (item.Tipo))
                return false;

            if (item.Preco <= 0)// verificamos se o valor informado
                                //é maior que 0
                return false; // caso nao ele ja retorna para fora do metodo

            //salvamos nosso item dentro da nossa tabela em memoria 
            contextDB.Livros.Add(item);
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
        public bool RemoverLivro(int id)
        {
            var livro = // Nossa variavel
                 contextDB// nossa basa de dados 
                 .Livros//Tabela de livros

                 .FirstOrDefault//buscamos o item para desativar
                 (x => x.Id == id);//informamos a regra de busca por id 

            if (livro == null) // verificamos se este item existe 
                return false;// caso nao ele sai de nosso metodo 
            livro.Ativo = false; // desativamos o item 
            contextDB.SaveChanges(); // salvamos em nosso banco 

            return true; // retornamos verdadeiro
        }

        
       

    }
}