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
    
    public partial class SNTt05_tipoMedioDePago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SNTt05_tipoMedioDePago()
        {
            this.MSTt01_medioDePago = new HashSet<MSTt01_medioDePago>();
        }
    
        public short idTipoMedioDePago { get; set; }
        public string codTipoMedioDePago { get; set; }
        public string descTipoMedioDePago { get; set; }
        public bool activo { get; set; }
        public System.DateTime fecRegistro { get; set; }
        public Nullable<System.DateTime> fecModificacion { get; set; }
        public Nullable<System.DateTime> fecEliminacion { get; set; }
        public long idUsuario { get; set; }
        public Nullable<long> idUsuarioModificar { get; set; }
        public Nullable<long> idUsuarioEliminar { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSTt01_medioDePago> MSTt01_medioDePago { get; set; }
    }
}