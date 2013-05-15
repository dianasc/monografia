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
                        pesoAtribuido = pesoAtr
                    };
                    
                    try
                    {
                        contexto.AspectosPorProjeto.Add(aspectoProjeto);
                        contexto.SaveChanges();
                    }
                    catch (Exception)
                    {
                        
                        throw;
                    }
                    
                }
            }

        }

        public static List<AspectoProjetoDTO> getAspectosPorProjeto(int idProjeto)
        {
            using (BaseDeConhecimentoEntities context = new BaseDeConhecimentoEntities())
            {
                var result = (from a in context.AspectosPorProjeto.AsEnumerable()
                              where a.idProjeto == idProjeto
                              select new AspectoProjetoDTO
                              {
                                  descricaoAspecto = a.Aspectos.descricao,
                                  idAspecto = a.idAspecto.ToString(),
                                  idProjeto = a.idProjeto.ToString(),
                                  nomeProjeto = a.Projeto.titulo,
                                  prioridade = a.prioridade.ToString(),
                                  valorAtribuido = a.pesoAtribuido.ToString()
                              }).ToList();

                return result;
            }
            
        }

    }
}