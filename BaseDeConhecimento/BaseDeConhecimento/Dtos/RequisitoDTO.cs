using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaseDeConhecimento.Dtos
{
    public class RequisitoDTO
    {
        public int idRequisito { get; set; }

        public Nullable<int> idProjeto { get; set; }

        [Required(ErrorMessage = "Informe o nome do requisito")]
        [Display(Name = "Nome")]
        [MaxLength(100)]
        public string nome { get; set; }

        [Required(ErrorMessage = "Informe a descrição do requisito")]
        [Display(Name = "Descrição")]
        [DataType(DataType.MultilineText)]
        [MaxLength(250)]
        public string descricao { get; set; }

        [Required(ErrorMessage = "Informe o critério de aceitação do requisito")]
        [Display(Name = "Critério de aceitação")]
        [DataType(DataType.MultilineText)]
        
        public string criterioAceitacao { get; set; }

        public string bugs { get; set; }
        public string qtdComunicacaoExterna { get; set; }
        public Nullable<System.DateTime> dataCadastro { get; set; }
    }
}