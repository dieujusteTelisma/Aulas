using ConsoleMigration.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMigration
{
    class Program
    {
        static MigrationContext db = new MigrationContext();
        static void Main(string[] args)
        {
            //iniciamos nossa base de dados 
            db.Usuarios.ToList().ForEach(x =>
            Console.WriteLine(x.Nome));
            Console.ReadKey();
        }
        //Enable-Migrations exrevendo isso no console para ver as imigrations que foram feito ou as modificacoes vai aparecer 
        //esta pasta de imigrations 
        //Update-DataBase para faer update  
        // vamos rodar o programa vai aparecer um erro enta pra resolver vamos no package manager console que esta embaixo do console e vamos acrecentar 
        // Add-Migration
        //AddEmailUsuario  porque a gente tinha acrecentado email no usuario depois de todo 
        // para funcionar temos que dar  Update-DataBase
        //depois foi criado na pasta migration  AddEmailUsuario e tambem foi criado mais a tabela email no banco de dados 

        // mais um Add-Migration
        //Name : AddControleUsuario
        //UpDate Database
        //Update-DataBase -Target AddEmailUsuario  este consegui voltar do jeito que era antes ate o eimail que criamos acabou apagando 
        // as outras tabelas que criou depois

        /*
         * vamos na pasta configuratio e screvendo 
         *  context.Usuarios.AddOrUpdate( new Model.Usuario(){
                Nome = "Webster",
                Login = "admin",
                Senha = "admin",
                Email = "admin@admin.com.br"
            });*/

        // e depois da um Update-DataBase

    }
}
