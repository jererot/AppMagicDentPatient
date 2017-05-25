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
    
    public partial class TNSt03_cuota
    {
        public long idCuota { get; set; }
        public decimal mtoDesembolso { get; set; }
        public decimal mtoPago { get; set; }
        public Nullable<System.DateTime> fecDesembolso { get; set; }
        public System.DateTime fecPago { get; set; }
        public bool esCancelado { get; set; }
        public bool activo { get; set; }
        public System.DateTime fecRegistro { get; set; }
        public Nullable<System.DateTime> fecModificacion { get; set; }
        public Nullable<System.DateTime> fecEliminacion { get; set; }
        public short idMedioDePago { get; set; }
        public long idEstadoDeCuenta { get; set; }
        public long idUsuario { get; set; }
        public Nullable<long> idUsuarioModificar { get; set; }
        public Nullable<long> idUsuarioEliminar { get; set; }
    
        public virtual MSTt01_medioDePago MSTt01_medioDePago { get; set; }
        public virtual TNSt05_estadoDeCuenta TNSt05_estadoDeCuenta { get; set; }
    }
}