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
    
    public partial class RHUt04_especialidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RHUt04_especialidad()
        {
            this.PROt04_servicio = new HashSet<PROt04_servicio>();
            this.RHUt02_empleadoEspecialidad = new HashSet<RHUt02_empleadoEspecialidad>();
        }
    
        public int idEspecialidad { get; set; }
        public string nombreEspecialidad { get; set; }
        public string abrvEspecialidad { get; set; }
        public bool activo { get; set; }
        public System.DateTime fecRegistro { get; set; }
        public Nullable<System.DateTime> fecModificacion { get; set; }
        public Nullable<System.DateTime> fecEliminacion { get; set; }
        public long idUsuario { get; set; }
        public Nullable<long> idUsuarioModificar { get; set; }
        public Nullable<long> idUsuarioEliminar { get; set; }
        public int idTipoDeEspeciliadad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROt04_servicio> PROt04_servicio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RHUt02_empleadoEspecialidad> RHUt02_empleadoEspecialidad { get; set; }
        public virtual RHUt13_tipoEspecialidad RHUt13_tipoEspecialidad { get; set; }
    }
}