using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCar.Model
{
    class ManageCarContext
    {
        public int IdContadorCar { get; set; } = 1;

        public ManageCarContext()
        {
            var carControl = new List<CarPoperty>();

          
        
            carControl.Add(new CarPoperty()
            {
                Id = 1,
                Carro = "Risus Company",
                Valor = 7.200,
                Data = DateTime.Parse("29/01/2019")
            });

        }
        public List<CarPoperty> ListaDeCarros { get; set; }
    }
}
