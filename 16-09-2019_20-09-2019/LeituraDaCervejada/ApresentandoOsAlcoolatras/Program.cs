﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCerveja.Controller;
using ListagemDeCerveja.Model; 

namespace ApresentandoOsAlcoolatras
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {
            cervejaController.adicionarCerveja2(new Cerveja()
            {
                Id = cervejaController.GetCervejas().Count + 1,
                Nome = "Giomar",
                Litros = 0.600,
                Alcool = 8,
                Valor = 0.98
            });
            cervejaController.GetCervejas().
                ForEach(x =>
                Console.WriteLine($" Id {x.Id} Nome --{x.Nome} Litros-- {x.Litros} Valor-- {x.Valor} Alcool-- {x.Alcool}"));

            Console.WriteLine("Total litros" + cervejaController.SomarTotalDeLitros());
            Console.WriteLine("Total Valor " + cervejaController.SomarTotalLista().ToString("C"));

            Console.ReadKey();
        }
    }
}
