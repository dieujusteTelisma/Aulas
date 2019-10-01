using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumLing
{
    class Program
    {
        static void Main(string[] args)
        {
            //chamamos nossa funcao 
            SomarInteiroPrimitivos();
            SomarInteirosLista();
            SomaBalasListaDeCriancas();
            Console.ReadKey();

        }
        /// <summary>
        /// Metodo que mostra numeros inteiros por um tipo primitivo
        /// </summary>
        private static void SomarInteiroPrimitivos()
        {
            //quando utlisamos "[]" em um tipo "primitivo" podemos criar uma colecao destes valores
            int[] colecaoInteiros =
                //alocamos memoria para nossa colecao de valor e informamos 
                //a quantidade de memoria que vamos ocupar 
                //memoriaOcupadaInt * quantidadeInformada
                new int[5]

            //aqui carregamos nossa colecao de valores
            //aqui nao posso acrecentar mais numeros
            { 1,2,3,4,5};

            Console.WriteLine(colecaoInteiros.Sum());

        }


        /// <summary>
        /// Metodo ue soma valores em uma lista 
        /// </summary>
        private static void SomarInteirosLista()
        {
            List<int> listaDeInteiros = new List<int>
            {
                //aqui podemos colocar mais numeros 
                //Nossa colecao de valores 
                1,2,3,4,5,6,7,8
            };

            Console.WriteLine(listaDeInteiros.Sum()); ;
        }

        /// <summary>
        /// Metodo que soma a quantidade de bala das criancas 
        /// </summary>
        private static void SomaBalasListaDeCriancas()
        {
            //Nossa lista de criancas foi criada e carrega em memoria 
            List<Crianca> criancas = new List<Crianca>()
            { 
            //criando uma nova crianca dentro da minha lista 
                new Crianca()
                {
                    Nome = "Joazinho",
                    Balas = 9
                }, // virgula separamos o objeto de outro
                 new Crianca()
                {
                    Nome = "Pedrinho",
                    Balas = 68
                }
            };
            Console.WriteLine("Quantidade total de balas das criancinhas levaram de venda");
            Console.WriteLine(
                //Soma a nossa quantidade de Balas 
                criancas.Sum(x => x.Balas));
        }

    }
}

