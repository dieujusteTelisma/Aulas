using ManageCar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCar.Controller
{
    public class CarController
    {
        
        
        private ManageCarContext contextDB = new ManageCarContext();
        

        public CarController()
        {

        }
       public void listar()
        {
            contextDB.ListaDeCarros.ForEach(x => Console.WriteLine($"id: {x.Id} carro: {x.Carro}"));
        }
   
    }
}
