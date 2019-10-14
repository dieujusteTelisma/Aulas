using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutBicicletas.Model
{
   public  class Bicicleta
    {
        [Key]

        public int Id { get; set; }

        [MaxLength(30)]

        [Required]

        public string Marca { get; set; }

        [MaxLength(30)]

        [Required]

        public string Modelo { get; set; }

        [Required]

        public double Preco { get; set; }



        public bool Ativo { get; set; } = true;
        public int UsuarioCriacao { get; set; } = 0;

        //definimos para alteracao do sistema quando nao logado usuario 0

        public int UsuarioAlteracao { get; set; } = 0;

        //setamos nossa data de criacao para data atual pela classe Datetime

        public DateTime DataCriacao { get; set; } = DateTime.Now;



        //Aqui definimos quando nao informado para data de alteracao aa data atual 



        public DateTime DataAlteracao { get; set; } = DateTime.Now;
    }
}
