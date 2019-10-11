using PutBicicletas.Controller;
using PutBicicletas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBicicleta
{
    class Program
    {
        static BicicletasController bicicletas = new BicicletasController();
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

                Console.WriteLine("1- inserir Bicicleta");

                Console.WriteLine("2- Atualizar Bicicleta");

                Console.WriteLine("3- Remover Bicicletas");

                Console.WriteLine("4- Listar Bicicleta ");

                Console.WriteLine("0 - Sair");

                //obtemos o menu escolhido pelo usuario 



                opcao = int.Parse(Console.ReadLine());

                //switch nos ajuda com a escolha da opcao 

                switch (opcao)

                {

                    //caso fo opcao 1 ele inseri celular 

                    case 1:

                        InserirBicicleta();

                        break;

                    case 2:

                        AtualizarBicicleta(); 

                        break;

                    case 3:

                        RemoverBicicleta();

                        break;

                    case 4:

                        ListarBicicleta();

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

        public static void InserirBicicleta()

        {

            //apresentamos a teça em que estamos

            Console.WriteLine("--Inserir Bicicleta --");

            Console.WriteLine("Informe a Marca da Bicicleta");

            var marca = Console.ReadLine();



            Console.WriteLine("Informe o Modelo da Bicicleta ");

            //obtemos o modelo da Bicicleta 

            var modelo = Console.ReadLine();

            //obtemos o valor da Bicicleta 

            Console.WriteLine("nforme o preco da Bicicleta");



            var preco = double.Parse(Console.ReadLine());

            // criamos o resultado para identificar sucesso ou erro

            var resultado = bicicletas// Nossa controler pelo nome 

                //que demos a ela 

            .InserirBicicleta(new Bicicleta()// uma nova bicicleta

                {

                    Marca = marca,

                    Modelo = modelo,

                    Preco = preco



              });



            if (resultado)

                Console.WriteLine("Bicicleta cadastrado com sucesso!");

            else // caso false apresenta o aviso

                Console.WriteLine("Erro ao cadastrar Bicicleta!");





        }

        //Atualizar 

        public static void AtualizarBicicleta()

        {

            //apresentamos a teça em que estamos

            Console.WriteLine("--Atualizar Bicicleta --");



            ListarBicicleta();

            //informamos ao usuario que ele precisa colocar o id para realizar a lateracao

            Console.WriteLine("Informe o Id para alteracao de registro");

            //obtemos o id informado

            var bicicletaId = int.Parse(Console.ReadLine());



            //obtemos do banco o item completo que vamos atualizar

            var bicicleta = bicicletas //banco de dados 

                .GetBicicletas()//obtemos as bicicletas

                .FirstOrDefault(x => x.Id == bicicletaId); // regra para obter a bicicleta



            if (bicicleta == null)

            {

                //informo que eese id nao encontrou um registro 

                Console.WriteLine("Id informado invalido");

                return;

            }





            Console.WriteLine("Informe a Marca da bicicleta");

            //obtemos a marca do usuario 

            bicicleta.Marca = Console.ReadLine();



            Console.WriteLine("Informe o Modelo da bicicleta ");

            //obtemos o modelo do aparelho 

            bicicleta.Modelo = Console.ReadLine();

            //obtemos o valor do aparelho 

            Console.WriteLine("nforme o preco da bicicleta ");



            bicicleta.Preco = double.Parse(Console.ReadLine());

            var resultado = bicicletas. // Nossa controller

                AtualizarBicicleta(bicicleta);//Metodo que atualiza o celular 

            if (resultado)

                Console.WriteLine("Celular atualizado com sucesso!");

            else

                Console.WriteLine("Erro ao atualizar a bicicleta");

        }

        //remover 



        public static void RemoverBicicleta()

        {

            //apresentamos a teça em que estamos

            Console.WriteLine("--Remover Celular --");



            ListarBicicleta();

            //informamos ao usuario que ele precisa colocar o id para realizar a lateracao

            Console.WriteLine("Informe o Id para alteracao de registro");

            //obtemos o id informado

            var celularId = int.Parse(Console.ReadLine());



            var resultado = bicicletas. // Nossa controller

             RemoverBicicleta(celularId);//Metodo que atualiza o celular 

            if (resultado)

                Console.WriteLine("Bicicleta removido com sucesso!");

            else

                Console.WriteLine("Erro ao remover Bicicleta");



            Console.ReadKey();

            Console.Clear();

        }

        public static void ListarBicicleta()

        {

            //listamos aqui par identificar p item que vamos alterar 

            Console.WriteLine("--Listar Bicicieta ");

            //listamos aqui par identificar p item que vamos alterar 

            bicicletas.GetBicicletas()// Obtemos a lista de celulares

                .ToList<Bicicleta>()// Convertemos para uma lista em memoria 

                .ForEach(x => // laco de repeticao para mostrar cada celular 

                //mostramos no console nosso celular 

                Console.WriteLine($"Id:{x.Id} Marca:{x.Marca} Modelo:{x.Modelo} Preço:{x.Preco}"));

            Console.ReadKey();

            Console.Clear();
        }
    }
}
