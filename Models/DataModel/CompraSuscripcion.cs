//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gym.Models.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class CompraSuscripcion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompraSuscripcion()
        {
            this.SuscripcionUsuario = new HashSet<SuscripcionUsuario>();
        }
    
        public int Id { get; set; }
        public int Cliente { get; set; }
        public int Suscripcion { get; set; }
        public System.DateTime Fecha { get; set; }
        public int NumeroRutinas { get; set; }
    
        public virtual Suscripcion Suscripcion1 { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SuscripcionUsuario> SuscripcionUsuario { get; set; }
    }
}
