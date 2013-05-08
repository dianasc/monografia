using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseDeConhecimento.Dtos;

namespace BaseDeConhecimento.Models
{
    public class TecnologiaBO
    {
        public static void Salvar(TecnologiaDto tecnologiaDto)
        {
            Tecnologia tecnlogia = new Tecnologia() { nome = tecnologiaDto.nome };

            using (BaseDeConhecimentoEntities contexto = new BaseDeConhecimentoEntities())
            {
                contexto.Tecnologia.Add(tecnlogia);
                contexto.SaveChanges();
            }
        }

        public static List<TecnologiaDto> GetAll()
        {
            using (BaseDeConhecimentoEntities contexto = new BaseDeConhecimentoEntities())
            {
                var usuarios = (from t in contexto.Tecnologia.AsEnumerable()
                                select new TecnologiaDto
                                {
                                    id = t.idTecnologia,
                                    nome = t.nome
                                }).ToList();

                return usuarios;
            }
        }
    }
}