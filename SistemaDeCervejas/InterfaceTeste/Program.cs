using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;



namespace InterfaceTeste
{
    class Program
    {
        static CervejaController controller = new CervejaController();
        static void Main(string[] args)
        {


            MostraMenuSistema();
            ListBeer();
            AdicionarCerveja();
            AdValor();
            AdTotalLItros();
            Berber();
            Console.ReadKey();

        }

        private static void MostraMenuSistema()
        {
            var menuEscolhido = int.MinValue;

            while (menuEscolhido != 0)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA de Gerenciar Cervejas");

                Console.WriteLine("Menu sistema");
                Console.WriteLine("1 - Listar Cervejas");
                Console.WriteLine("2 - Cadastrar Cervejas");
                Console.WriteLine("3 - Retornar o valor total de nossa lista");
                Console.WriteLine("4 - Retornar o valor total  em litro de nossa lista");
                Console.WriteLine("5 - Calcular peso de uma pessoa");
                //Aqui vamos pegar numero digitado
                menuEscolhido = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                //Executar proxima funcao
                switch (menuEscolhido)
                {
                    case 1:
                        ListBeer();

                        break;
                    case 2:
                        AdicionarCerveja();
                        break;
                    case 3:
                        AdValor();
                        Console.ReadKey();
                        break;
                    case 4:
                        AdTotalLItros();
                        Console.ReadKey();
                        break;
                    case 5:
                        Berber();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }

        }

        private static void ListBeer()
        {
            controller.GetCervejas()
               .ForEach(i => Console.WriteLine($"{i.Id} {i.Nome}  LItros {i.Litros} Alcool {i.Alcool}  Valor {i.Valor}"));
            Console.ReadLine();




        }
        private static void AdicionarCerveja()
        {
            //Identificamos que o mesmo esta na parte de cadastro de livros do sistema
            Console.WriteLine("Cadastrar Cervejas dentro do sistema");
            //Informamos que para dar continuidade ele deve informar um nome para Cerveja
            Console.WriteLine("Nome da Cerveja para cadastro:");
            //obtemos esta info do usuario 
            var nomeDaCerveja = Console.ReadLine();
            //com isso temos temos disponivel nele ferramentas que nos ajudam a realizar as tarefas 
            //como adicionar um item a nossa lista de Cerveja 

            controller.AdicionarCervejas(new Cerveja()

            {

                Nome = nomeDaCerveja
            });

            //indico que finalizamos o processo de cadastro da Cerveja , assim o usuario ja sabe 
            //que  o mesmo foi realizado e sem erros 
            Console.WriteLine("Cerveja cadastro com sucesso!");
            //Readkey apenas para que ele visualize esta informacão


        }

        public static void AdValor()
        {
            Console.WriteLine($" Total {controller.getTotal()}");
        }

        public static void AdTotalLItros()
        {
            Console.WriteLine($" TotalLitro {controller.getTotalLItro()}");
        }

        public static void Berber()
        {
            Console.WriteLine($" TotalLitro {controller.getTotalLitro()}");
        }
    }
}








