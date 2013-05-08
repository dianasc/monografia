using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaseDeConhecimento.Dtos
{
    public class AtividadeDTO
    {
        public string idAtividade { get; set; }

        [Required(ErrorMessage = "Informe o nome da atividade.")]
        [Display(Name="Nome")]
        public string nome { get; set; }

        [Required(ErrorMessage ="Informe a descrição da atividade.")]
        [Display(Name="Descrição")]
        [DataType(DataType.MultilineText)]
        public string descricao { get; set; }

        [Display(Name="Tempo estimado")]
        public string tempoEstimado { get; set; }

        [Display(Name = "Tempo de execução")]
        public string tempoExecucao { get; set; }

        [Display(Name = "Complexidade")]
        public string complexidade { get; set; }

        [Display(Name = "Escala de importância")]
        public string escalaDeImportancia { get; set; }
    }
}