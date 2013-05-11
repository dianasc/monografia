using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseDeConhecimento.Dtos;
using System.Globalization;

namespace BaseDeConhecimento.Models
{
    public class AspectoBO
    {
        public static void Salvar(AspectoDTO aspectoDto)
        {
            Aspectos aspecto = new Aspectos()
            {
                codigoIdentificacao = aspectoDto.codigoIdentificacao,
                descricao = aspectoDto.descricao,
                tipo = int.Parse(aspectoDto.tipo),
                peso = double.Parse(aspectoDto.peso)
            };
            using (BaseDeConhecimentoEntities contexto = new BaseDeConhecimentoEntities())
            {
                contexto.Aspectos.Add(aspecto);
                contexto.SaveChanges();
            }
        }

        public static List<AspectoDTO> GetAll()
        {
            using (BaseDeConhecimentoEntities context = new BaseDeConhecimentoEntities())
            {
                var result = (from a in context.Aspectos.AsEnumerable()
                              select new AspectoDTO
                              {
                                  codigoIdentificacao = a.codigoIdentificacao,
                                  descricao = a.descricao,
                                  idAspecto = a.idAspecto.ToString(),
                                  tipo = a.tipo.ToString(),
                                  peso = a.peso.ToString()
                              }
                                  ).ToList();

                return result;
            }
        }

        public static void adicionarAspectoPorProjeto(List<AspectoProjetoDTO> aspectos)
        {
            using (BaseDeConhecimentoEntities contexto = new BaseDeConhecimentoEntities())
            {
                foreach (AspectoProjetoDTO item in aspectos)
                {
                    decimal pesoAtr = Convert.ToDecimal(item.valorAtribuido, CultureInfo.CreateSpecificCulture("en-us"));
                    AspectosPorProjeto aspectoProjeto = new AspectosPorProjeto()
                    {
                        idAspecto = int.Parse(item.idAspecto),
                        idProjeto = int.Parse(item.idProjeto),
                        prioridade = int.Parse(item.prioridade),
                        pesoAtribuido = Convert.ToDecimal("3,5")
                    };

                    contexto.SaveChanges();
                }
            }

        }

    }
}