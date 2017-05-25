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
    
    public partial class TNSt01_comprobanteEmitido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TNSt01_comprobanteEmitido()
        {
            this.TNSt02_comprobanteEmitidoDtl = new HashSet<TNSt02_comprobanteEmitidoDtl>();
            this.TNSt06_medioDePagoDtl = new HashSet<TNSt06_medioDePagoDtl>();
        }
    
        public long idComprobanteEmitido { get; set; }
        public string serie { get; set; }
        public string numComprobanteEmitido { get; set; }
        public System.DateTime fecRegistro { get; set; }
        public Nullable<System.DateTime> fecModificacion { get; set; }
        public Nullable<System.DateTime> fecAnulacion { get; set; }
        public string razonAnulacion { get; set; }
        public bool esAnulado { get; set; }
        public bool activo { get; set; }
        public Nullable<System.DateTime> fecEmision { get; set; }
        public Nullable<System.DateTime> fecVencimiento { get; set; }
        public Nullable<System.DateTime> fecCancelacion { get; set; }
        public decimal mtoTotal { get; set; }
        public decimal mtoSubTotal { get; set; }
        public decimal mtoImpto { get; set; }
        public decimal mtoDescuento { get; set; }
        public decimal porcentajeImpto { get; set; }
        public decimal porcentajeDescuento { get; set; }
        public string obsvComprobanteEmitido { get; set; }
        public string info01 { get; set; }
        public string info02 { get; set; }
        public string info03 { get; set; }
        public Nullable<System.DateTime> fecha01 { get; set; }
        public Nullable<System.DateTime> fecha02 { get; set; }
        public Nullable<System.DateTime> fecha03 { get; set; }
        public long idCita { get; set; }
        public short idEstadoComprobante { get; set; }
        public int idSucursal { get; set; }
        public int idTipoComprobante { get; set; }
        public int idMoneda { get; set; }
        public short idImpto { get; set; }
        public long idUsuario { get; set; }
        public Nullable<long> idUsuarioModificar { get; set; }
        public Nullable<long> idUsuarioAnular { get; set; }
    
        public virtual CLlt05_cita CLlt05_cita { get; set; }
        public virtual MSTt04_sucursal MSTt04_sucursal { get; set; }
        public virtual SNTt02_impuesto SNTt02_impuesto { get; set; }
        public virtual SNTt03_moneda SNTt03_moneda { get; set; }
        public virtual SNTt04_tipoComprobante SNTt04_tipoComprobante { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt02_comprobanteEmitidoDtl> TNSt02_comprobanteEmitidoDtl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt06_medioDePagoDtl> TNSt06_medioDePagoDtl { get; set; }
        public virtual TNSt04_estadoComprobante TNSt04_estadoComprobante { get; set; }
    }
}