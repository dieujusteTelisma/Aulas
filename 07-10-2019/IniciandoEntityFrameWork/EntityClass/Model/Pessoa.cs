using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class Pessoa
    {
        [Key] // Aqui temos uma anotacoa que indica que nossa chave é o campo logo 
        //abaixo da nossa anotacoa e a palavra chave [Key]
        //Significa que ele e nossa chave primaria 
        public int Id { get; set; } 
        public string Nome { get; set; }
    }
}
