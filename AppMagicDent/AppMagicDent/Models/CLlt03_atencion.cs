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
    
    public partial class CLlt03_atencion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLlt03_atencion()
        {
            this.CLIt01_anamnesis = new HashSet<CLIt01_anamnesis>();
            this.CLlt12_examenFisico = new HashSet<CLlt12_examenFisico>();
            this.CLlt13_funcionVital = new HashSet<CLlt13_funcionVital>();
            this.CLlt10_estudioCompl = new HashSet<CLlt10_estudioCompl>();
            this.CLlt08_diagnostico = new HashSet<CLlt08_diagnostico>();
            this.CLlt11_evolucion = new HashSet<CLlt11_evolucion>();
        }
    
        public long idAtencion { get; set; }
        public string codAtencion { get; set; }
        public System.DateTime fecRegistro { get; set; }
        public long idUsuario { get; set; }
        public Nullable<long> idCita { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt01_anamnesis> CLIt01_anamnesis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLlt12_examenFisico> CLlt12_examenFisico { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLlt13_funcionVital> CLlt13_funcionVital { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLlt10_estudioCompl> CLlt10_estudioCompl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLlt08_diagnostico> CLlt08_diagnostico { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLlt11_evolucion> CLlt11_evolucion { get; set; }
        public virtual CLlt05_cita CLlt05_cita { get; set; }
    }
}