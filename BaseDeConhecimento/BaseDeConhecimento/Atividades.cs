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
    
    public partial class Atividades
    {
        public Atividades()
        {
            this.Notas = new HashSet<Notas>();
            this.Tags = new HashSet<Tags>();
        }
    
        public int idAtividade { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public Nullable<System.TimeSpan> tempoEstimado { get; set; }
        public Nullable<System.TimeSpan> tempoExecucao { get; set; }
        public Nullable<int> complexidade { get; set; }
        public Nullable<int> escalaDeImportancia { get; set; }
    
        public virtual ICollection<Notas> Notas { get; set; }
        public virtual ICollection<Tags> Tags { get; set; }
    }
}
