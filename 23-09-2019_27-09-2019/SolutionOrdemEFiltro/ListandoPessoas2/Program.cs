using ListandoPessoas2.Controller;
using ListandoPessoas2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListandoPessoas2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui carregamos nossa caixa de ferramentas de pessoas 
            //podemos agora listar e demais funcionalidades 
            PessoaController pessoaController
                //nesta parte ao iniciar em memoria 
                //iniciamos o coonstrutore 
                = new PessoaController();
            //aqui acessamos nossa lista de pessoas
            pessoaController.ListaDePessoasPublica
                //usamos o foreach do linq para percorrer a lista
                .ForEach(i => //criamos a variavel i para receber o item da nossa lista 

                //imprimimos a informacao de cada item da nosssa lista 
                 MostraInformacoes(i));

            MostraIdentificador("--------------------Lista ordenada por nome----------");
            pessoaController.GetPessoasOrdenadaAsc().ForEach(i => MostraInformacoes(i));

            MostraIdentificador("---------Lista ordenada Por Data ---------- ");
            pessoaController.GetPessoasOrdenadaDescPelaDataNascimento().ForEach(i => MostraInformacoes(i));

            MostraIdentificador("---------Listar who has more then 500 R$ ---------- ");
            pessoaController.GetPessoasComMaisPilasNaCarteira(500).ForEach(i => MostraInformacoes(i));

            //Mostrando a informacao dinamica
            MostraIdentificador($"Lista maiores de {18} anos ");
            pessoaController.GetPessoasComIdadeMaiorA().ForEach(i => MostraInformacoes(i));

            MostraIdentificador($"Lista menores de {16}  anos ");
            pessoaController.GetPessoasComIdadeMenorQue().ForEach(i => MostraInformacoes(i));

            Console.ReadKey();
        }

        /// <summary>
        /// Metodo para mostrar a informacao inicial de cada listagem
        /// </summary>
        /// <param name="nomeAcao">Identificador da listagem</param>
        private static void MostraIdentificador(string nomeAcao)
        {
            Console.WriteLine(string.Format("-----{0,20}-----", nomeAcao));
        }

        /// <summary>
        /// Metodo que mostra no console foramtado nosso objeto 
        /// "pessoa"
        /// </summary>
        /// <param name="pessoa">objeto pessoa qur vamos apresentar </param>
        private static void MostraInformacoes(Pessoa pessoa)
        {

            //Nosso  template que apresenta as informacoes bonitinhas
            // fomat usa {0} essa expressao para colocar de acodo
            //com a ordm informada dos parametros
            string template = "Id {0,3} Nome {1,10} Nascimento {2,10} Carteira {3,5}";
            //Recebemos as informacoes bonitinhas com o string format
            string textoFormatado =

                   //String.Format e usado para formatar as string 
                   //deixando nosso texto padrao e apresentavel
                   string.Format(
                       //Nosso primeiro parametro é o template que usamos 
                       template,
                       //apos informar o template , temos os parametros 
                       //este metodo espera um array de parametros ou seja 
                       //podemos passar muitos parametros nele 
                       pessoa.Id,
                       pessoa.Nome,
                       pessoa.DataNascimento.ToShortDateString(),
                       pessoa.Carteira.ToString("C"));

            Console.WriteLine(textoFormatado);

        }
    }
}
