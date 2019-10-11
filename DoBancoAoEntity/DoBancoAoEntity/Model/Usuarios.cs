namespace DoBancoAoEntity.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuarios : ControleUsuario
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Usuario { get; set; }

      
    }
}
