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
    
    public partial class Suscripcion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Suscripcion()
        {
            this.CompraSuscripcion = new HashSet<CompraSuscripcion>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int NumeroRutinas { get; set; }
        public int DuracionRutina { get; set; }
        public decimal Valor { get; set; }
        public double Plazo { get; set; }
        public Nullable<int> NumeroIntegrantes { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompraSuscripcion> CompraSuscripcion { get; set; }
    }
}
