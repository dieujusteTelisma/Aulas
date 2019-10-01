using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Model
{
   public class SistemaCarrosContext
    {
        

        public List<Carro> ListaDeCarros { get; set; }

        public SistemaCarrosContext()
        {
            //Criamos nossa lista de Carros em memoria
            //caso contrario ela fica null
            ListaDeCarros = new List<Carro>();


            ListaDeCarros.Add(new Carro() { Id = 1, Marca = "Risus Company", Modelo = "Toyota", Ano = 2012, Cilindradas = 200 , Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 2, Marca = "Cursus Et Ltd", Modelo = "CheriQQ", Ano = 2012, Cilindradas = 200, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 3, Marca = "Odio Etiam Ligula Company", Modelo = "Ferari", Ano = 2012, Cilindradas = 200, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 4, Marca = "Tellus Nunc Lectus Company", Modelo = "Toyota", Ano = 2012, Cilindradas = 200, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 5, Marca = "Enim Nisl Elementum Inc.", Modelo = "MAbel", Ano = 2012, Cilindradas = 200, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 6, Marca = "Montes Institute", Modelo = "Toyota", Ano = 2012, Cilindradas = 200, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 7, Marca = "Aliquam Erat LLC", Modelo = "Coubobo", Ano = 2012, Cilindradas = 200, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 8, Marca = "Velit Sed Malesuada Associates", Modelo = "Toyota", Ano = 2012, Cilindradas = 200, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 9, Marca = "Semper Egestas Urna Inc.", Modelo = "Malberk", Ano = 2012, Cilindradas = 200, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 10, Marca = "Nulla Foundation", Modelo = "Richer", Ano = 2012, Cilindradas = 200, Portas = 4 });
        }
        public List<Carro> ListaCarrosPublica { get { return ListaDeCarros; } }

        

    }
}
