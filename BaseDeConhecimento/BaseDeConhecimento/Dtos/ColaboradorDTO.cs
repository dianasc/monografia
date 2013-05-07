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
        
        [Required]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        public string email { get; set; }
    }
}