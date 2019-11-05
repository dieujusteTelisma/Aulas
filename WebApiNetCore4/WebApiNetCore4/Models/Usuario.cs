using System;
using System.Collections.Generic;

namespace WebApiNetCore4.Models
{
    // devemos saber que podemos criar um uma database no sql depois para ter conexao com banco de dados o que devemos 
    //fazer é ir no tool /connect to database / no sever name colocamos isso MSSQLLocalDB 
    // depois vamos devemos chamar o banco com : Scaffold-DbContext "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BancoUsuario" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
    //usando o nome do nosso banco de dados. para chamar o banco temos um powerpoint com info importante permintindo criar nosso ambiante de cor 



    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
    }
}
