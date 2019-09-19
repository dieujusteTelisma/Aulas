using MInhaTerceiraClase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*[Systema de amigos fixo]
 1 - Criar uma classe Amigos, com isso devemos definir as seguintes informações para esta classe:
	 a - Nome do tipo string, tempo de amizade do tipo int.
	 b - Inserimos manualmente pelo método Add de nossa lista, 3 amigos.
     c - Agora apenas listamos esta informações dentro do console.*/

namespace MInhaTerceiraClase
{
    class Program
    {
        static void Main(string[] args)
        {
            var friendshipTime = new List<Amigos>();

            friendshipTime.Add(new Amigos()

            
            {
                nome = "Maria",
                tempo = 5
            });

            friendshipTime.Add(new Amigos()

            {
                nome = "Jose",
                tempo = 2
            });

            friendshipTime.Add(new Amigos()

            {
                nome = "Marco",
                tempo = 6
            });


            friendshipTime.ForEach(i =>
            Console.WriteLine($" {i.nome} tem {i.tempo} anos de amizade comigo"));
            

            Console.WriteLine("Informe o nome de um amigo");

            var nomeAmigo = Console.ReadLine();
            Console.WriteLine("Quanto voces se encontram : Por favor digite o ano");
            var ano = int.Parse(Console.ReadLine());


            if (ano <= 2019)
            {
                Console.WriteLine($" {nomeAmigo} tem  {2019 - ano}  anos de amizade contigo");

            }

            else
            {
                Console.WriteLine("ano invalido");
               
            }
            Console.ReadKey();
        }
    }

}
