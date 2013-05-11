using BaseDeConhecimento.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaseDeConhecimento.Dtos
{
    public class AspectoDTO
    {
        public string idAspecto { get; set; }

        [Required(ErrorMessage = "Informe o código de identificação do aspecto")]
        [Display(Name = "Código de identificação")]
        public string codigoIdentificacao { get; set; }

        [Required(ErrorMessage = "Selecione o tipo de aspecto")]
        [Display(Name = "Tipo de aspecto")]
        public string tipo { get; set; }

        [Required(ErrorMessage = "Informe a descrição do aspecto")]
        [Display(Name = "Descrição")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "Informe o valor de peso do aspecto")]
        [Display(Name = "Peso")]
        public string peso { get; set; }

        public static SelectList SelectAspectos
        {
            get
            {
                List<AspectoDTO> aspectosResult = AspectoBO.GetAll();
                var selectItems = new Dictionary<string, string> { };

                foreach (AspectoDTO item in aspectosResult)
                {
                    selectItems.Add(item.idAspecto, item.descricao.Trim());
                }

                return new SelectList(selectItems, "Key", "Value");
            }
            set { }
        }
    }
}