using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseDeConhecimento.Models;

namespace BaseDeConhecimento.Dtos
{
    public class ProjetoDTO
    {
        public int idProjeto { get; set; }
        [Required(ErrorMessage = "Informe o título do projeto")]
        [Display(Name = "Título")]
        public string titulo { get; set; }

        [Required(ErrorMessage = "Informe a descrição do projeto")]
        [Display(Name = "Descrição")]
        public string descricao { get; set; }

        [Display(Name = "Data de previsão início")]
        public string dataPrevistaInicio { get; set; }

        [Display(Name = "Data de previsão término")]
        public string dataPrevistaTermino { get; set; }

        [Display(Name = "Custo previsto")]
        public string custoPrevisto { get; set; }

        [Display(Name = "Custo real")]
        public string custoReal { get; set; }

        [Display(Name = "Data início")]
        public string dataInicio { get; set; }

        [Display(Name = "Data fim")]
        public string dataFim { get; set; }
        
        [Display(Name = "Aspecto")]
        public string aspecto { get; set; }

        [Display(Name = "Valor atribuído")]
        public string valorAspecto { get; set; }

   
    }
}