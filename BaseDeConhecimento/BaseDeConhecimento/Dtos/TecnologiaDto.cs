using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaseDeConhecimento.Dtos
{
    public class TecnologiaDto
    {
        [Required(ErrorMessage="Informe o nome da tecnologia")]
        [Display(Name="Nome")]
        public string nome { get; set; }
        public int id { get; set; }
    }
}