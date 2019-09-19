using MinhaQuartaClase1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 2 - Criar uma classe Pessoa, com isso devemos definir as seguintes informações para esta classe:
	 a - Nome do tipo string,Idade do tipo int, Sexo do tipo char e Altura do tipo double
	 b - Devemos cadastrar estas informações com base nos conhecimentos já passados no console.
		 b.a - Para cadastrar lembramos WriteLine e ReadLine
		 b.b - Para visualizar informações lembramos que a lista dispõe de um Foreach
     c - Junto com as demais atividades, agora devemos listar estas informações.
	 BONUS - Pessoal com maior conhecimento pode adicionar RG e CPF junto com isso adicionar validações das informações 
	 no cadastro, e Adicionar menus recursivos.*/


namespace MinhaQuartaClase1

{
    class Program
    {
        static List<Pessoa> listaPessoa = new List<Pessoa>();

        static void Main(string[] args)
        {

            Console.WriteLine("Digite 1 para inserir. ");
            //Console.WriteLine("Digite 2 para listar. ");
            var opcao = Console.ReadLine();

            //switch (opcao)
            //{
            //    case "1":
            //        AdicionaLista();
            //        break;
            //    case "2":
            //        listar();
            //        break;
            //    default:

            //}

            while (opcao == "1")
            {
                AdicionaLista();
                Console.WriteLine("Digite 1 para inserir. ");
                opcao = Console.ReadLine();
            }
            listar();
            Console.ReadKey();
        }

        public static void AdicionaLista()
        {
            Pessoa objetoPessoa = new Pessoa();

            Console.WriteLine("Informe nome");
            objetoPessoa.Nome = Console.ReadLine();

            Console.WriteLine("Informe idade");
            objetoPessoa.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe sexo");
            objetoPessoa.Sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Informe altura");
            objetoPessoa.Altura = double.Parse(Console.ReadLine());

            listaPessoa.Add(objetoPessoa);
        }

        public static void listar()
        {
            listaPessoa.ForEach(ob => Console.WriteLine($"Nome {ob.Nome} Idade: {ob.Idade} Sexo: {ob.Sexo} Altura: {ob.Altura}"));
        }
    }
}
