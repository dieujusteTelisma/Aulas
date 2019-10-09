
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    public class Usuario : ControleUsuario  //  isso se chama extendereste permite que o usuario pegou todo que tem dentro do usuario é um compatilhamento de dados

    {
        [Key] // definindo com primary key e identity (1,1)
        public int Id { get; set; }
        [MaxLength(50)] // delimitmos um tamanho maximo par o campo string 
        public string Nome { get; set; }
        [MaxLength(30)]
        [Required]
        public string Login { get; set; }
        [MaxLength(30)]
        [Required]
        public string Senha { get; set; }

    }
}
