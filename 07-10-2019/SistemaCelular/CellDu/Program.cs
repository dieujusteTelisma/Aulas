using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;
using CatalogoCelulares.Controller;

namespace CellDu
{
    class Program


    {
        //1- Colocar console app para statar o projetot : set as start up ptojet
        //2- Adicionar referencia Catalogo de celulares 
        //3- Adicionar Entity mem nosso projeto Ex; tools nuget package Manager - manage nuget package 
        //4 Adicionar using ao osso projeto MOdelo , controller 
        static CelularesController celulares = new CelularesController();
        static void Main(string[] args)
        {
            //definimos uma opcao de menu inicial 
            var opcao = int.MinValue;
            //definimos que emquanto for diferente de 0
            //ele continua em nosso loop
            while (opcao != 0)
            {
                //Apresentacao do menu inicial
                Console.WriteLine("Escolha um nenu");
                Console.WriteLine("1- inserir Celular");
                Console.WriteLine("2- Atualizar Celular");
                Console.WriteLine("3- Remover Celular");
                Console.WriteLine("4- Listar Celular ");
                Console.WriteLine("0 - Sair");
                //obtemos o menu escolhido pelo usuario 

                opcao = int.Parse(Console.ReadLine());
                //switch nos ajuda com a escolha da opcao 
                switch (opcao)
                {
                    //caso fo opcao 1 ele inseri celular 
                    case 1:
                        InserirCelular();
                        break;
                    case 2:
                        AtualizarCelular();
                        break;
                    case 3:
                        RemoverCelular();
                        break;
                    case 4:
                        ListarCelular(); 
                        break;
                    case 0:
                        //informamos que estamos saindo do sistema
                        Console.WriteLine("saindo do sistema");
                        break;
                    default://Caso colocar uma opcao nao valida 
                        Console.WriteLine("opcao invalida");
                        break;
                }
                //Colocamos true para informar que nao deve aparecer 
                //tela o valor pressionado
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial");
                Console.ReadKey(true);
            }
        }

        //inserir 
        public static void InserirCelular()
        {
            //apresentamos a teça em que estamos
            Console.WriteLine("--Inserir Celular --");
            Console.WriteLine("Informe a Marca do celular");
            var marca = Console.ReadLine();

            Console.WriteLine("Informe o Modelo do celular ");
            //obtemos o modelo do aparelho 
            var modelo = Console.ReadLine();
            //obtemos o valor do aparelho 
            Console.WriteLine("nforme o preco do aparelho");

            var preco = double.Parse(Console.ReadLine());
            // criamos o resultado para identificar sucesso ou erro
            var resultado = celulares// Nossa controler pelo nome 
                                     //que demos a ela 
                .InserirCelular(new Celular()// um novo celular 
                {
                    Marca = marca,
                    Modelo = modelo,
                    Preco = preco

                });

            if (resultado)
                Console.WriteLine("Celular cadastrado com sucesso!");
            else // caso false apresenta o aviso
                Console.WriteLine("Erro ao cadastrar aparelho!");


        }
        //Atualizar 
        public static void AtualizarCelular()
        {
            //apresentamos a teça em que estamos
            Console.WriteLine("--Atualizar Celular --");

            ListarCelular();
            //informamos ao usuario que ele precisa colocar o id para realizar a lateracao
            Console.WriteLine("Informe o Id para alteracao de registro");
            //obtemos o id informado
            var celularId = int.Parse(Console.ReadLine());

            //obtemos do banco o item completo que vamos atualizar
            var celular = celulares //banco de dados 
                .GetCelulars()//obtemos os celulares
                .FirstOrDefault(x => x.Id == celularId); // regra para obter o celular 

            if (celular == null)
            {
                //informo que eese id nao encontrou um registro 
                Console.WriteLine("Id informado invalido");
                return;
            }


            Console.WriteLine("Informe a Marca do celular");
            //obtemos a marca do usuario 
            celular.Marca = Console.ReadLine();

            Console.WriteLine("Informe o Modelo do celular ");
            //obtemos o modelo do aparelho 
            celular.Modelo = Console.ReadLine();
            //obtemos o valor do aparelho 
            Console.WriteLine("nforme o preco do aparelho");

            celular.Preco = double.Parse(Console.ReadLine());
            var resultado = celulares. // Nossa controller
                AtualizarCelular(celular);//Metodo que atualiza o celular 
            if (resultado)
                Console.WriteLine("Celular atualizado com sucesso!");
            else
                Console.WriteLine("Erro ao atualizar aparelho");
        }
        //remover 

        public static void RemoverCelular()
        {
            //apresentamos a teça em que estamos
            Console.WriteLine("--Remover Celular --");

            ListarCelular();
            //informamos ao usuario que ele precisa colocar o id para realizar a lateracao
            Console.WriteLine("Informe o Id para alteracao de registro");
            //obtemos o id informado
            var celularId = int.Parse(Console.ReadLine());

            var resultado = celulares. // Nossa controller
              RemoverCelular(celularId);//Metodo que atualiza o celular 
            if (resultado)
                Console.WriteLine("Celular removido com sucesso!");
            else
                Console.WriteLine("Erro ao remover  aparelho");

            Console.ReadKey();
            Console.Clear();
        }
        public static void ListarCelular()
        {
            //listamos aqui par identificar p item que vamos alterar 
            Console.WriteLine("--Listar Celular ");
            //listamos aqui par identificar p item que vamos alterar 
            celulares.GetCelulars()// Obtemos a lista de celulares
                .ToList<Celular>()// Convertemos para uma lista em memoria 
                .ForEach(x => // laco de repeticao para mostrar cada celular 
                //mostramos no console nosso celular 
                Console.WriteLine($"Id:{x.Id} Marca:{x.Marca} Modelo:{x.Modelo} Preço:{x.Preco}"));
            Console.ReadKey();
            Console.Clear();
        }
    }
}
