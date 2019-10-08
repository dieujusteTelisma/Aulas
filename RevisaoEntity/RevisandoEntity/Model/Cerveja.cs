using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoEntity.Model
{
   //Inicialmente devmos deixar a classe publica 
    public class Cerveja

    {
        //chamada pelo (control + "." : usando  o using System.ComponentModel.DataAnnotations;
        [Key]// chave primaria , auto incrementada
        public int Id { get; set; }
        //Aqui definimos a quantidade maxima de caracteres 
        [StringLength(50)] // para nosso campo 'Nome' dentro do banco
        [Required] // Identifica que este campo é obbligatorio "Not NUll"
        public string Nome { get; set; }
        [StringLength(30)] //tamanho maximo de caracteres para otipo 
        public string Tipo { get; set; }
        public double Teor { get; set; }
    }
}
