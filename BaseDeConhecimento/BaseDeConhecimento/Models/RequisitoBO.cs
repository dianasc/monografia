using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseDeConhecimento.Dtos;

namespace BaseDeConhecimento.Models
{
    public class RequisitoBO
    {

        public static void Salvar(RequisitoDTO requisitoDto)
        {
            Requisito requisito = new Requisito()
            {
                bugs = string.IsNullOrEmpty(requisitoDto.bugs) ? 0 : int.Parse(requisitoDto.bugs),
                criterioAceitacao = requisitoDto.criterioAceitacao,
                descricao = requisitoDto.descricao,
                idProjeto = requisitoDto.idProjeto,
                nome = requisitoDto.nome,
                dataCadastro = DateTime.Now,
                qtdComunicacaoExterna = string.IsNullOrEmpty(requisitoDto.qtdComunicacaoExterna) ? 0 : int.Parse(requisitoDto.qtdComunicacaoExterna)
            };
            using (BaseDeConhecimentoEntities contexto = new BaseDeConhecimentoEntities())
            {
                contexto.Requisito.Add(requisito);
                contexto.SaveChanges();
            }
        }

        public static List<RequisitoDTO> GetRequisitosPorProjeto(int idProjeto)
        {
            using (BaseDeConhecimentoEntities contexto = new BaseDeConhecimentoEntities())
            {
                var requisitos = (from r in contexto.Requisito.AsEnumerable()
                                  where r.idProjeto == idProjeto
                                  select new RequisitoDTO
                                  {
                                      bugs = r.bugs.ToString(),
                                      criterioAceitacao = r.criterioAceitacao,
                                      dataCadastro = r.dataCadastro,
                                      descricao = r.descricao,
                                      idProjeto = r.idProjeto,
                                      idRequisito = r.idRequisito,
                                      nome = r.nome,
                                      qtdComunicacaoExterna = r.qtdComunicacaoExterna.ToString()
                                  }).ToList();

                return requisitos;
            }

        }

        public static RequisitoDTO GetRequisito(int idRequisito)
        {
            using (BaseDeConhecimentoEntities contexto = new BaseDeConhecimentoEntities())
            {
                var requisito = (from r in contexto.Requisito.AsEnumerable()
                                 where r.idRequisito == idRequisito
                                 select new RequisitoDTO
                                 {
                                     bugs = r.bugs.ToString(),
                                     criterioAceitacao = r.criterioAceitacao,
                                     dataCadastro = r.dataCadastro,
                                     descricao = r.descricao,
                                     idProjeto = r.idProjeto,
                                     idRequisito = r.idRequisito,
                                     nome = r.nome,
                                     qtdComunicacaoExterna = r.qtdComunicacaoExterna.ToString()
                                 }).First();

                return requisito;
            }
        }

        public static void Editar(RequisitoDTO requisitoDto)
        {
            using (BaseDeConhecimentoEntities contexto = new BaseDeConhecimentoEntities())
            {
                var requisitoUpdate = (from r in contexto.Requisito.AsEnumerable()
                                       where r.idRequisito == requisitoDto.idRequisito
                                       select r).First();

                requisitoUpdate.bugs = string.IsNullOrEmpty(requisitoDto.bugs) ? 0 : int.Parse(requisitoDto.bugs);
                requisitoUpdate.criterioAceitacao = requisitoDto.criterioAceitacao;
                requisitoUpdate.descricao = requisitoDto.descricao;
                requisitoUpdate.nome = requisitoDto.nome;
                requisitoUpdate.qtdComunicacaoExterna = string.IsNullOrEmpty(requisitoDto.qtdComunicacaoExterna) ? 0 : int.Parse(requisitoDto.qtdComunicacaoExterna);
                contexto.SaveChanges();

            }
        }
    }
}