using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCar.Model
{
    public class ManageCarContext
    {
       // public int IdContadorCar { get; set; } = 1;

        public ManageCarContext()
        {
            ListaDeCarros = new List<CarPoperty>();

            ListaDeCarros.Add(new CarPoperty()
            {
                Id = 1,
                Carro = "Risus Company",
                Valor = 7.200,
                Data = DateTime.Parse("29/01/2019")
            });

            ListaDeCarros.Add(new CarPoperty()
            {
                Id = 2,
                Carro = "Risus Associates",
                Valor = 9.961,
                Data = DateTime.Parse("10/02/2019")
            });


        }
        public List<CarPoperty> ListaDeCarros { get; set; }
    }
}
