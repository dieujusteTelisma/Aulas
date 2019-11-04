using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiNetCore.Model
{
    // para criar um api netcore temos que escolher framework net core dar nome depois procurar emcima o numeor 3.0 e desmarcar as confugurations
    //  temos que ir no tool nugetsegunda option e installin entity framework core .sqlserver e sedserver.in mormery
    
    // depois fomos no startup para acrecentar  :services.AddDbContext<WebApiContext>(opt =>
    //  opt.UseInMemoryDatabase("DBConect")); na linha 29 

    // depois devemos ir no controller para clicar no add / new scaffold item / Api controller with actions , empty entity framework
    //depois fomos no launchSetting.json para acresentar : "Api/Bicicletas" na linha 15 

// depois fomos na bicicleta controller na linha 85 para acresentat o nameof
    public class Bicicleta
    {
        [Key]

        public int id { get; set; }
        public string Marca { get; set; }

        public string Modelo { get; set; }


    }
}
