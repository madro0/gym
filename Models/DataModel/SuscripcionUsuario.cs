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
    
    public partial class SuscripcionUsuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SuscripcionUsuario()
        {
            this.HistorialReporteAsistencia = new HashSet<HistorialReporteAsistencia>();
        }
    
        public int Id { get; set; }
        public int CompraSuscripcion { get; set; }
        public int Clientes { get; set; }
        public int NumeroRutinas { get; set; }
        public System.DateTime FechaDeVencimiento { get; set; }
    
        public virtual CompraSuscripcion CompraSuscripcion1 { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistorialReporteAsistencia> HistorialReporteAsistencia { get; set; }
    }
}
