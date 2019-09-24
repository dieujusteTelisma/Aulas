using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDePessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            var cadastroDePessoas = new List<Pessoa>();
           
            #region Carregandoos dados 
            //Spears
            cadastroDePessoas.Add(new Pessoa()
            {
                Id = 1,
                Nome = "Spears",
                DataNascimento = DateTime.Parse("07/11/2004"),
                Carteira = 846.96
            });


            //Manga
            cadastroDePessoas.Add(new Pessoa()
            {
                Id = 2,
                Nome = "Swanson",
                DataNascimento = DateTime.Parse("20/06/2003"),
                Carteira = 233.09
            });
            cadastroDePessoas.Add(new Pessoa()
            {
                Id = 3,
                Nome = "Gay",
                DataNascimento = DateTime.Parse("03/12/2001"),
                Carteira = 911.92
            });
            cadastroDePessoas.Add(new Pessoa()
            {
                Id = 4,
                Nome = "Gregory",
                DataNascimento = DateTime.Parse("02/01/2000"),
                Carteira = 911.92
            });
            cadastroDePessoas.Add(new Pessoa()
            {
                Id = 5,
                Nome = "Olson",
                DataNascimento = DateTime.Parse("02/01/2000"),
                Carteira = 911.92
            });


            cadastroDePessoas.Add(new Pessoa()
            {
                Id = 6,
                Nome = "Garza",
                DataNascimento = DateTime.Parse("01/04/2000"),
                Carteira = 360.41
            });

            cadastroDePessoas.Add(new Pessoa()
            {
                Id = 7,
                Nome = "Sweet",
                DataNascimento = DateTime.Parse("12/03/2003"),
                Carteira = 312.76
            });

            cadastroDePessoas.Add(new Pessoa()
            {
                Id = 8,
                Nome = "Cline",
                DataNascimento = DateTime.Parse("26/03/2002"),
                Carteira = 312.76
            });
            cadastroDePessoas.Add(new Pessoa()
            {
                Id = 9,
                Nome = "Oliver",
                DataNascimento = DateTime.Parse("05/07/2004"),
                Carteira = 513.76
            });

            cadastroDePessoas.Add(new Pessoa()
            {
                Id = 10,
                Nome = "Vang",
                DataNascimento = DateTime.Parse("10/07/2000"),
                Carteira = 271.05
            });

            cadastroDePessoas.Add(new Pessoa()
            {

                Id = 11,
                Nome = "Maddox",
                DataNascimento = DateTime.Parse("29/05/2004"),
                Carteira = 783.97
            });

            cadastroDePessoas.Add(new Pessoa()
            {

                Id = 12,
                Nome = "Garrett",
                DataNascimento = DateTime.Parse("03/06/2006"),
                Carteira = 154.11
            });

            cadastroDePessoas.Add(new Pessoa()
            {

                Id = 13,
                Nome = "Mcintosh",
                DataNascimento = DateTime.Parse("06/07/2006"),
                Carteira = 902.80
            });

            cadastroDePessoas.Add(new Pessoa()
            {

                Id = 14,
                Nome = "Yang",
                DataNascimento = DateTime.Parse("29/04/2005"),
                Carteira = 550.48
            });


            #endregion

            #region Lista 1

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("-Listar estas informações em ordem decrescente Pela data de nascimento");

            cadastroDePessoas.OrderByDescending(x => x.DataNascimento).ToList<Pessoa>().
                ForEach(i =>
                Console.WriteLine($"Id {i.Id} Nome: {i.Nome} data {i.DataNascimento}"));
            #endregion

            #region Lista 2

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Listar estas informações em ordem crescente Pelo nome");

            cadastroDePessoas.OrderBy(x => x.Nome).ToList<Pessoa>().ForEach(i =>
                Console.WriteLine($"Id {i.Id} Nome: {i.Nome} "));
            #endregion

            #region Lista 3

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine(" Listar as pessoas que contem mais de 500 reais na carteira ");

            var filtroPessoa = cadastroDePessoas
                //Aqui filtramos os registro maiores de 100 gramas
                .Where(x => x.Carteira > 500)
                //Ordernamos estes valores pelo nome
                .OrderBy(x => x.Nome);
            filtroPessoa.ToList<Pessoa>()
               .ForEach(i => Console.WriteLine($"Id {i.Id} Nome {i.Nome} Peso {i.Carteira}"));
            #endregion


            #region Lista 4


            #endregion
            Console.ReadKey();

            //    SELECT*
            //FROM  Clientes
            //ORDER BY Nome ASC;

        }
    }
}
