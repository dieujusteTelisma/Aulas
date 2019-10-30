using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaParaRegistrarImoveisApi.Models
{
    public class Proprietario 
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string DataNascimento { get; set; }

        public string Email { get; set; }
    }

    // antes de dar um Enable-Migrations dentro do console vamos executar primeiro o 
    //PM> Uninstall-Package EntityFramework -Force
    //PM> Install-Package EntityFramework -Pre
    // Add-Migration permite que ele cria as tabelas dentro da base de dados 
}