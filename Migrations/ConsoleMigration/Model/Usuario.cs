using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConsoleMigration.Model
{
    // nesta classe de web. framework escolhemos o Empty´para acriacao da solucao 
    public class Usuario : ControleUsuario
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        public Nivel Nivel { get; set; } = Nivel.Usuario;
    }
}