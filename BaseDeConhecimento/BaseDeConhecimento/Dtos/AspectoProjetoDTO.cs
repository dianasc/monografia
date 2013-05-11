using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaseDeConhecimento.Dtos
{
    public class AspectoProjetoDTO
    {
        public string idAspecto { get; set; }
        
        public string descricaoAspecto { get; set; }

        public string idProjeto { get; set; }
        [Display(Name="Nome do Projeto")]
        
        public string nomeProjeto { get; set; }
        
        [Display(Name = "Prioridade")]
        
        public string prioridade { get; set; }
        
        [Display(Name = "Peso atribuído")]
        
        public string valorAtribuido { get; set; }
    }
}