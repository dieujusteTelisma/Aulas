namespace DoBancoAoEntity.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Carros : ControleUsuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Carros()
        {
            Vendas = new HashSet<Vendas>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Modelo { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ano { get; set; }

        public int Marca { get; set; }
        [StringLength(10)]
        public string Cor { get; set; }

        public virtual Marcas Marcas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vendas> Vendas { get; set; }
    }
}
