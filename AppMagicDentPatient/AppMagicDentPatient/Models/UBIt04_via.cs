//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppMagicDentPatient.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UBIt04_via
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UBIt04_via()
        {
            this.RHUt09_persona = new HashSet<RHUt09_persona>();
        }
    
        public int idVia { get; set; }
        public string descVia { get; set; }
        public string abrvVia { get; set; }
        public bool estado { get; set; }
        public System.DateTime fecRegistro { get; set; }
        public Nullable<System.DateTime> fecModificacion { get; set; }
        public Nullable<System.DateTime> fecEliminacion { get; set; }
        public long idUsuario { get; set; }
        public Nullable<long> idUsuarioModificar { get; set; }
        public Nullable<long> idUsuarioEliminar { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RHUt09_persona> RHUt09_persona { get; set; }
    }
}
