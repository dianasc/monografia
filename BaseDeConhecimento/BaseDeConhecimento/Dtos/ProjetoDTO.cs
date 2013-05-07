using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseDeConhecimento.Dtos
{
    public class ProjetoDTO
    {
        public int idProjeto { get; set; }

        public string titulo { get; set; }

        public string descricao { get; set; }

        public string dataPrevistaInicio { get; set; }

        public string dataPrevistaTermino { get; set; }

        public string custoPrevisto { get; set; }

        public string custoReal { get; set; }

        public string dataInicio { get; set; }

        public string dataFim { get; set; }
    }
}