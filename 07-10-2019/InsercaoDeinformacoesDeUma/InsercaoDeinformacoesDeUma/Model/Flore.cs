using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsercaoDeinformacoesDeUma.Model
{
  public class Flore
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        [Required]
        public string Nome { get; set; }
        [Required]
        public int Quantidade { get; set; }

        public bool Ativo { get; set; } = true;


    }
}
