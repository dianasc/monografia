//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaseDeConhecimento
{
    using System;
    using System.Collections.Generic;
    
    public partial class Aspectos
    {
        public Aspectos()
        {
            this.AspectosPorProjeto = new HashSet<AspectosPorProjeto>();
        }
    
        public int idAspecto { get; set; }
        public string codigoIdentificacao { get; set; }
        public Nullable<int> tipo { get; set; }
        public string descricao { get; set; }
        public Nullable<double> peso { get; set; }
    
        public virtual ICollection<AspectosPorProjeto> AspectosPorProjeto { get; set; }
    }
}
