//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppMagicDent.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROt05_tipoDeServicio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROt05_tipoDeServicio()
        {
            this.PROt04_servicio = new HashSet<PROt04_servicio>();
        }
    
        public int idTipoDeServicio { get; set; }
        public string descTipoDeServicio { get; set; }
        public bool activo { get; set; }
        public System.DateTime fecRegistro { get; set; }
        public Nullable<System.DateTime> fecModificacion { get; set; }
        public Nullable<System.DateTime> fecEliminacion { get; set; }
        public long idUsuario { get; set; }
        public Nullable<long> idUsuarioModificar { get; set; }
        public Nullable<long> idUsuarioEliminar { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROt04_servicio> PROt04_servicio { get; set; }
    }
}
