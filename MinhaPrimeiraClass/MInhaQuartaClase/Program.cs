using MInhaQuartaClase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  2 - Criar uma classe Pessoa, com isso devemos definir as seguintes informações para esta classe:
	 a - Nome do tipo string,Idade do tipo int, Sexo do tipo char e Altura do tipo double
	 b - Devemos cadastrar estas informações com base nos conhecimentos já passados no console.
		 b.a - Para cadastrar lembramos WriteLine e ReadLine
		 b.b - Para visualizar informações lembramos que a lista dispõe de um Foreach
     c - Junto com as demais atividades, agora devemos listar estas informações.
	 BONUS - Pessoal com maior conhecimento pode adicionar RG e CPF junto com isso adicionar validações das informações 
	 no cadastro, e Adicionar menus recursivos.

 */


namespace MInhaQuartaClase
{
    class Program
    {
        private static object nome;

        static void Main(string[] args)

        {
            SignUpPeople();
        }
        public static void SignUpPeople()
        {

            //i create  a object because i want the user inform dates
            var peopleList = new List<Pessoas>();

            Pessoas pessoas = new Pessoas(); // mesma coisa  var pessoas = new Pessoas();

            Console.WriteLine("inform name");
            pessoas.nome = Console.ReadLine();
            Console.WriteLine("inform Age");
            pessoas.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("inform Sex");
            pessoas.sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("inform height");
            pessoas.altura = double.Parse(Console.ReadLine());
            peopleList.Add(pessoas);

            peopleList.ForEach(ob => Console.WriteLine($"o nome é {ob.nome} idade {ob.idade} sexo  {ob.sexo} altura {ob.} "));

            Console.ReadKey();
        }
    }
}






