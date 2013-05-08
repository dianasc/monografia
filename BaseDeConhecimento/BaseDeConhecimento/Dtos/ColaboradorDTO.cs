using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaseDeConhecimento.Dtos
{
    public class ColaboradorDTO
    {
        
        public int idUsuario { get; set; }
        
        [Required(ErrorMessage="Informe o nome do colaborador.")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Required(ErrorMessage="Informe o e-mail do colaborador.")]
        [Display(Name = "E-mail")]
        public string email { get; set; }
    }
}