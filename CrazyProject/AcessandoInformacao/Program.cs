using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;

namespace AcessandoInformacao
{
    class Program
    {
        public static object MessageBox { get; private set; }

        static void Main(string[] args)
        {
            //CalculaArea();
            MenuSistema(); // devemos colocar static na frente do menusistema para tirar error
            Console.ReadKey();
        }

        private static void MenuSistema()
        {
            Console.WriteLine("Escolha uma das opcoes do menu: ");
            Console.WriteLine("1 - Calculo de area");
            Console.WriteLine("2 - Mostrar Animacao");
            Console.WriteLine("3 -  Listar as cervejas ");
            Console.WriteLine("4 -  Listar Car");
            Console.WriteLine("5 - sair do sistema");

            var menuEscolhido =int.Parse(Console.ReadLine());

            switch (menuEscolhido)
            {
                case 1:
                    {
                        CalculaArea();
                        MenuSistema();

                    } break;
                case 2:

                    {
                        // quando nao é static cpodemos colocar new objeto static ja esta na memoria
                        AnimacoesEmFrames.Iniciar();
                       
                        MenuSistema();
                        
                    } break;

                case 3:
                    {
                        ShowList.ListaString();
                        
                    }
                    break;

                case 4 :
                    {
                        ListCar.ListaCar();

                    }
                    break;


                case 5:

                    {

                        Console.WriteLine("Saindo.....");
                       
                        return;

                    }

                    //break;

                default:
                    break;
            }
        }

        public static void CalculaArea()
        {
            Console.WriteLine("Informa o lado do quadrado");
            var ladoQuadrado = int.Parse(Console.ReadLine());

            var bibliotecaCalculos = new CalculoDeArea();

            Console.WriteLine($"Minha area é {bibliotecaCalculos.CalcularAreaDoQuadrado(ladoQuadrado)}");
            Console.ReadKey();
        }

    }
}
