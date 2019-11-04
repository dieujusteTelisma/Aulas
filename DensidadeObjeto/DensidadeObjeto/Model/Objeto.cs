using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DensidadeObjeto.Model
{
    public class Objeto
    {
        [Key]
        public int id { get; set; }

        public double Peso { get; set; }

        public double Massa { get; set; }

    }
}
