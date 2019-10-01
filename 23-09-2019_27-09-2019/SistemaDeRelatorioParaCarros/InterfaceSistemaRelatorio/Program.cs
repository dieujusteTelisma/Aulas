using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRelatorioCarros.Controller;
using SistemaRelatorioCarros.Model;

namespace InterfaceSistemaRelatorio
{
    class Program
    {
        static VendasController vendasController = new VendasController();
        static void Main(string[] args)
        {
            Console.WriteLine("Informações das vendas realizadas durante o ano de 2019");
            vendasController.GetVendas().ForEach(i => ImprimeInformacoes(i));

            Console.ReadKey();

            MostraMenuRelatorio();
        }

        private static void MostraMenuRelatorio()
        {
            Console.Clear();

            Console.WriteLine("Menu de relatorios");
            Console.WriteLine("1 - Relatorio por periodo mensal");
            Console.WriteLine("0 - Sair");

            var menuEscolhido = int.MinValue;

            while (menuEscolhido != 0)
            {
                menuEscolhido = int.Parse(Console.ReadLine());

                switch (menuEscolhido)
                {
                    case 1:
                        {
                            Console.WriteLine("Informe o mês para realizar o filtro");
                            //Obtemos a informação do mês
                            var mesEscolhido = int.Parse(Console.ReadLine());
                            //Passamos o mes na mesma função para obter as vendas
                            var listaDoPeriodoEscolhido = vendasController.GetVendas(mesEscolhido);

                            //Aqui imprimimos as informações para o usuario
                            listaDoPeriodoEscolhido.ForEach(i => ImprimeInformacoes(i));

                            var totalMes = listaDoPeriodoEscolhido
                                //Somamos todos os registro multiplicando as valor venda vezes a quantidade 
                                .Sum(x => x.Valor * x.Quantidade);

                            var mediaPeriodo = listaDoPeriodoEscolhido
                                //Média de todos os registro multiplicando as valor venda vezes a quantidade 
                                .Average(x => x.Valor * x.Quantidade);

                            //Mostramos o mes escolhido e o valor total neste mês gerado
                            Console.WriteLine($"Total do mês {mesEscolhido} é {totalMes.ToString("C")}");
                            //Mostramos o mes escolhido e o valor médio de vendas no mes gerado
                            Console.WriteLine($"Média do mês {mesEscolhido} é {mediaPeriodo.ToString("C")}");

                            Console.ReadKey();
                        }
                        break;
                }
            }

        }

        public static void ImprimeInformacoes(Venda vendas)
        {
            Console.WriteLine(
                string.Format("Id {0,3} Carro {1,-35} Valor {2,-10} Quantidade {3,3} Data {4,12}"
                , vendas.Id
                , vendas.Carro
                , vendas.Valor.ToString("C")
                , vendas.Quantidade
                , vendas.Data.ToShortDateString()));
        }
    }
}

/*1 - Sei que temos uma planilha do Excel e temos os dados dentro dela.
 pegar a planilha. ok
2 - Ao analisar a planilha temos a seguinte estrutura.
      Id,Carro,Valor,Quantidade,Data

Etapas de criação da minha aplicação  resumo 
    1 - Criar minha class Library
    	1.2 - Cria minha Estrutura de Dados dentro da Model -  ok
    	1.3 - Criar minha massa de dados Context dentro da Model - ok
    	1.4 - Criar meu controle de dados dentro da Controller - Ok
    2 - Criar meu console App



Etapas de criação da minha aplicação resumo do resumo
    1 - Criar minha class Library  ok 
    2 - Criar meu console App ok
    

Etapas para mostrar o conteúdo das vendas de 2019
	1 - Precisamos Obter as informações de vendas do nosso Context - ok
	2 - Na nossa controller criamos uma forma de retornar estas informações para nosso console app. ok
	3 - No console app vamos apresentar estas informações para o Usuário. 

 Etapas para criar o relatório de vendas 
	1- Devemos criar um menu para ele ter a opção de mostrar o relatório - ok
	2 - Pegar o mês que ele deseja visualizar este relatório  - ok	
	     2.1 - Adicionar esta opção Controller  - ok
	3 - Apresentar estas informações para o usuários - ok
	4 - Somar total de vendas e apresentar ao usuário na mesma tela - ok
	5 - Mostrar a media de vendas para aquele período - ok*/

