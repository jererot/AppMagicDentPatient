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
    
    public partial class CLIt01_anamnesis
    {
        public long idAnamnesis { get; set; }
        public string descAnamnesis { get; set; }
        public long idAtencion { get; set; }
    
        public virtual CLlt03_atencion CLlt03_atencion { get; set; }
    }
}