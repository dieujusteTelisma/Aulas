using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Classe que controla as informações dos nossos livros
    /// </summary>
    public class LivrosController
    {
        LocacaoContext contextDB = new LocacaoContext();
        /// <summary>
        /// Metodo construtor que prepara o terreo para já iniciar com livros pré cadastrados
        /// </summary>

        public IQueryable<Livro> GetLivros()
        {
            //Retorna os alunos dentro do sistema
            return contextDB.Livros;
        }

        public void AddLivro(Livro item)
        {
            //Adiciono meu aluno na minha lista em memoria 
            contextDB.Livros.Add(item);
            //Salvo essa informação no banco de dados
            contextDB.SaveChanges();

        }

        //Atualizacao 
        /// <summary>
        /// Metodo que atualiza um registro valido do nosso sitema 
        /// </summary>
        /// <param name="item">Item que vamos atualizar </param>
        /// <returns>Retorna verdadeiro caso item exista</returns>
        public bool AtualizarLivro(Livro item)
        {
            var livro = //Definimos uma variavel para ocelular 

                contextDB//Usamos o banco de daodos 
                .Livros // Nossa tabela que tem os celulares 
                .FirstOrDefault //Buscamos em nossa tabela o celular 
                (x => x.Id == item.Id); //Regra para realizar a busca 

            //falamos que nosso celular da tabela vai ser igual 
            //Nosso celualr que estamos passando 
            if (livro == null) // verifiscmos ele realmente encontrou um celular 
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
        public bool RemoverCelular(int id)
        {
            var livro = // Nossa variavel
                 contextDB// nossa basa de dados 
                 .Livros//Tabela de celular 

                 .FirstOrDefault//buscamos o item para desativar
                 (x => x.Id == id);//informamos a regra de busca por id 

            if (livro == null) // verificamos se este item existe 
                return false;// caso nao ele sai de nosso metodo 
            livro.Ativo = false; // desativamos o item 
            contextDB.SaveChanges(); // salvamos em nosso banco 

            return true; // retornamos verdadeiro
        }

        
        /*


                    -----------------------------------------------------------------------
        {
            /// <summary>
            /// Classe que controla as informações dos nossos livros
            /// </summary>
            public class LivrosController
            {
                private LocacaoContext contextDB = new LocacaoContext();
                /// <summary>
                /// Metodo construtor que prepara o terreo para já iniciar com livros pré cadastrados
                /// </summary>
                public LivrosController()
                {

                }
                /// <summary>
                /// Metodo que adiciona o livro em nossa lista já "instanciada" criada dentro do 
                /// construtor
                /// </summary>
                /// <param name="parametroLivro">Informações do livro que vamos adicionar</param>
                public void AdicionarLivro(Livro parametroLivro)
                {
                    //Adicionamos o livro em nossa lista.
                    parametroLivro.Id = contextDB.IdContadorLivros++;
                    contextDB.ListaDeLivros.Add(parametroLivro);
                }
                /// <summary>
                /// Metodo que retorna a lista de livros
                /// </summary>
                /// <returns>Lista de livros</returns>
                public List<Livro> RetornaListaDeLivros()
                {
                    return contextDB.ListaDeLivros.Where(x => x.Ativo).ToList<Livro>();
                }
                /// <summary>
                /// Metodo para desativar o registro de livro pelo Id
                /// </summary>
                /// <param name="identificadoID">Id do livro que vamos desativar</param>
                public void RemoverLivroPorId(int identificadoID)
                {
                    //FirstOrDefault retorna null em caso de não encontrar um registro
                    var livro = contextDB.ListaDeLivros.FirstOrDefault(x => x.Id == identificadoID);
                    //Tratamento do valor quando ele não encontrar um livro com o id
                    if (livro != null)
                        livro.Ativo = false;
                }

              */

    }
}