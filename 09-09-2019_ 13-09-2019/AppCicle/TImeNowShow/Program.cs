using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TImeNowShow
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"hora Atual : {DateTime.Now.ToString("HH:MM:ss.fff")}");
                Thread.Sleep(1000); // a gente da ctrl +ponto + enter para acrecentar o using trading
            }
        }
    }
}
