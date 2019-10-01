using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosPublicos
{
    public class Program
    {
        static void Main(string[] args)

        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---Sistema  conversor de moedas cabuloso ---");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Informe um valor a ser convertido");

            var valorAserConvertido = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Informe uma moeda para conversão:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("  DOLAR");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  EURO");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("  YEN");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  BTC");

            var moedaAlvoParaConverter = Console.ReadLine();

            ConvertMoeda(valorAserConvertido, moedaAlvoParaConverter);

            Console.ReadKey();
        }

        /// <summary>
        /// Metodo criado para chamar numa outra classe 
        /// </summary>
        public static void ConversorMonetarioSis()
        {


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---Sistema  conversor de moedas cabuloso ---");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Informe um valor a ser convertido");

            var valorAserConvertido = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Informe uma moeda para conversão:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("  DOLAR");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  EURO");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("  YEN");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  BTC");

            var moedaAlvoParaConverter = Console.ReadLine();

            ConvertMoeda(valorAserConvertido, moedaAlvoParaConverter);

        }
         
        public static void ConvertMoeda(double minhamoeda, string moedaAlvo)
        {


            switch (moedaAlvo)

            {

                case "DOLAR":
                    Console.WriteLine(FormatarNumeroDecimalEmDolar(minhamoeda));

                    break;
                case "EURO":
                    Console.WriteLine(FormatarNumeroDecimalEmEuro(minhamoeda));

                    break;
                case "YEN":

                    Console.WriteLine(FormatarNumeroDecimalYen(minhamoeda));

                    break;

                case "BTC":

                    Console.WriteLine(FormatarNumeroDecimalBitcoin(minhamoeda));

                    break;

                default:

                    break;

            }

        }

        /// <summary>
        /// Metodo que converte meu numero em real pala dolar 
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>

        private static string FormatarNumeroDecimalEmDolar(double meuNumero) // colocamos string porque vamos chamar ele en outro metodo

        {

            return (meuNumero / 4.5008).ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));


        }

        private static string FormatarNumeroDecimalEmEuro(double meuNumero)

        {

            return (meuNumero / 4.5266).ToString("C", CultureInfo.CreateSpecificCulture("en-EUR"));

        }
        private static string FormatarNumeroDecimalYen(double meuNumero)

        {

            return (meuNumero / 0.038).ToString("C", CultureInfo.CreateSpecificCulture("en-Yen"));

        }

        private static string FormatarNumeroDecimalBitcoin(double meuNumero)

        {

            return (meuNumero * 0.000024).ToString("C", CultureInfo.CreateSpecificCulture("en-BTC"));

        }


    }
}

