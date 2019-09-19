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
            Lambda();

            List<Pessoa> pessoas = new List<Pessoa>();
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

        public static void Lambda()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            Pessoa p1 = new Pessoa();
            p1.Nome = "Gabriel";
            p1.Sexo = 'M';
            p1.Altura = 2.01;
            p1.Idade = 29;
            pessoas.Add(p1);

            Pessoa p2 = new Pessoa();
            p2.Nome = "Elóra";
            p2.Idade = 21;
            p2.Sexo = 'F';
            p2.Altura = 1.53;
            pessoas.Add(p2);

            Pessoa p3 = new Pessoa();
            p3.Nome = "Ronaldo";
            p3.Idade = 15;
            p3.Sexo = 'M';
            p3.Altura = 1.6;
            pessoas.Add(p3);

            List<Pessoa> menoresIdade = new List<Pessoa>();

            foreach (Pessoa p in pessoas)
            {
                if (p.Idade < 18)
                {
                    menoresIdade.Add(p);
                }
            }
            //Lambda = Where/OrderBy/FirstOrDefault
            pessoas.Where(c => c.Altura > 2 && c.Nome.ToUpper().StartsWith("E"));

            List<Pessoa> pessoasOrdenadasPorAltura = pessoas.OrderByDescending(p => p.Altura).ThenBy(c => c.Idade).ToList();

            //  pessoas.Where(pes => pes.Idade < 18);


            var listaMaiores = pessoas.Where(pes => pes.Idade > 18).ToList();

            listaMaiores.ForEach(ob => Console.WriteLine($"Nome: {ob.Nome} "));


            menoresIdade.ForEach(ob => Console.WriteLine($"Menor Nome: {ob.Nome} "));

        }

    }
}
