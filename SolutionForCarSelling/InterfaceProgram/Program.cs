using ManageCar.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProgram
{
    class Program
    {
        
        static CarController carController = new CarController();

        static void Main(string[] args)
        {

            Console.WriteLine("-----Listar os carros-----------");
            carController.listar();

       
           Console.ReadKey();
            


        }
    }
}

