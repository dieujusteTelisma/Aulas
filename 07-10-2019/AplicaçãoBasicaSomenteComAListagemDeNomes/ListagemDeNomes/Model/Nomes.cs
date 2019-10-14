using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeNomes.Model
{
   public  class Nomes
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
