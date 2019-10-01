using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOreachNaLIsta
{
    class Program
    {


        static void Main(string[] args)
        {
            // ListaDateTime();
            // ListaString();
            //ListIntNumber();
            ListaDecimal();
            //FormatarNumeroDecimalEmDolar();
        }


        //  <sumary>
        // mostrar lista de datas definidas 

        private static void ListaDateTime()
        {

            var minhaLista = new List<DateTime>();

            minhaLista.Add(new DateTime(2019, 9, 17));
            minhaLista.Add(new DateTime(2019, 9, 18));
            minhaLista.Add(new DateTime(2019, 9, 19));
            minhaLista.Add(new DateTime(2019, 9, 20));



            //  minhaLista.ForEach(minhaData => Console.WriteLine(minhaData.ToString("yyyy/MM/dd")));
            //  Console.ReadKey();

            minhaLista.ForEach(minhaData => Console.WriteLine(minhaData.ToLongDateString()));
            Console.ReadKey();
        }

        //mostra lista de string definidas 
        private static void ListaString()

        {
            var minhaLista = new List<string>();

            minhaLista.Add("XIAOMI");
            minhaLista.Add("IPHONE APP");
            minhaLista.Add("SAMSUNG");
            minhaLista.Add("NOKIA");




            minhaLista.ForEach(i => Console.WriteLine(i)); // i  significa item da lista 



            // este comando abaixo é igual a  = minhaLista.ForEach(i => Console.WriteLine(i));
            //foreach (var item in minhaLista)
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadKey();

        }

        private static void ListIntNumber()
        {

            var minhaLista = new List<int>();

            minhaLista.Add((17));
            minhaLista.Add((18));
            minhaLista.Add((19));
            minhaLista.Add((20));

            minhaLista.ForEach(i => Console.WriteLine(i));
            Console.ReadKey();
        }

        private static void ListaDecimal()
        {

            var minhaLista = new List<double>();

            minhaLista.Add(3.15);
            minhaLista.Add(4.98);
            minhaLista.Add(2.42);
            minhaLista.Add(0.85);

            minhaLista.ForEach(meuDecimal => Console.WriteLine(meuDecimal.ToString("C") + " = US " +
            // tostring("C") para format casas decimal
            FormatarNumeroDecimalEmDolar(meuDecimal)));

            Console.WriteLine("Reais em Euro");

            minhaLista.ForEach(meuDecimal => Console.WriteLine(meuDecimal.ToString("C") + " = EUR " +
            FormatarNumeroDecimalEmEuro(meuDecimal)));

            Console.WriteLine("Reais em Yen");

            minhaLista.ForEach(meuDecimal => Console.WriteLine(meuDecimal.ToString("C") + " = Yen " +
            FormatarNumeroDecimalYen(meuDecimal)));

           Console.WriteLine("Reais em BitCoint");

            minhaLista.ForEach(meuDecimal => Console.WriteLine(meuDecimal.ToString("C") + " = Bitcoin " +
            FormatarNumeroDecimalBitcoin(meuDecimal)));


            Console.WriteLine("Voce quer converter um outro valor? (1) sim  ou apertar qualquer tecla mais enter para sair do programa");

            var resposta = Console.ReadLine();
            if (resposta == "1")
            {
                Console.WriteLine("digite o valor");
                var numero = double.Parse(Console.ReadLine());

                Console.WriteLine("Escolhe a moeda");
                var moeda = Console.ReadLine();
               // string dolar;
                if (moeda == "dolar")
                    Console.WriteLine(FormatarNumeroDecimalEmDolar(numero));

                if (moeda == "euro")


                    Console.WriteLine(FormatarNumeroDecimalEmEuro(numero));


                if (moeda == "yen")

                    Console.WriteLine(FormatarNumeroDecimalYen(numero));

                if (moeda == "bitcoin")

                    Console.WriteLine(FormatarNumeroDecimalBitcoin(numero));
                else

                    Console.WriteLine("obrigado por visitar nosso site.");
                Console.ReadKey();

            }



        }
        /// <summary>
        /// Metodo que converte meu numero em real para dolar
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string FormatarNumeroDecimalEmDolar(double meuNumero) // colocamos string porque vamos chamar ele en outro metodo

        {

            return (meuNumero / 5.5008).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));

        }

        /// <summary>
        /// Metodo que converte de real para euro
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        /// 

         
        private static string FormatarNumeroDecimalEmEuro(double meuNumero)

        {

            return (meuNumero / 4.5266).ToString("C", CultureInfo.CreateSpecificCulture("en-EUR"));

        }

        /// <summary>
        /// para yen 
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string FormatarNumeroDecimalYen(double meuNumero)

        {

            return (meuNumero / 0.038).ToString("C", CultureInfo.CreateSpecificCulture("en-Yen"));

        }
        /// <summary>
        /// para bitcoin
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string FormatarNumeroDecimalBitcoin(double meuNumero)

        {

            return (meuNumero * 0.000024).ToString("C", CultureInfo.CreateSpecificCulture("en-BTC"));

        }
    }

}
