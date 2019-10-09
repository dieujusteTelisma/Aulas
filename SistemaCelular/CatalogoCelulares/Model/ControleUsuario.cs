using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    public class ControleUsuario
    {
        //definimos o campo com o valor default 'true ' para nossos registros
        public bool Ativo { get; set; } = true;
        //definimos 0 para usuario criado pelo sistema sem usuario logado
        public int UsuarioCriacao { get; set; } = 0;
        //definimos para alteracao do sistema quando nao logado usuario 0
        public int UsuarioAlteracao { get; set; } = 0;
        //setamos nossa data de criacao para data atual pela classe Datetime
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        //Aqui definimos quando nao informado para data de alteracao aa data atual 

        public DateTime DataAlteracao { get; set; } = DateTime.Now;
    }
}
