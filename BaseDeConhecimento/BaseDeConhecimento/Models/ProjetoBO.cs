using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseDeConhecimento.Dtos;
using System.Globalization;

namespace BaseDeConhecimento.Models
{
    public class ProjetoBO
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dadosProjeto"></param>
        public static void Salvar(ProjetoDTO dadosProjeto)
        {
            Projeto projeto = new Projeto() { titulo = dadosProjeto.titulo, descricao = dadosProjeto.descricao };
            
            if (!string.IsNullOrEmpty(dadosProjeto.custoPrevisto))
            {
                projeto.custoPrevisto = decimal.Parse(dadosProjeto.custoPrevisto);
            }

            if (!string.IsNullOrEmpty(dadosProjeto.custoReal))
            {
                projeto.custoReal = decimal.Parse(dadosProjeto.custoReal);
            }

            if (!string.IsNullOrEmpty(dadosProjeto.dataFim))
            {
                projeto.dataFim = DateTime.Parse(dadosProjeto.dataFim, CultureInfo.CreateSpecificCulture("pt-br"));
            }

            if (!string.IsNullOrEmpty(dadosProjeto.dataInicio))
            {
                projeto.dataInicio = DateTime.Parse(dadosProjeto.dataInicio, CultureInfo.CreateSpecificCulture("pt-br"));
            }

            if (!string.IsNullOrEmpty(dadosProjeto.dataPrevistaInicio))
            {
                projeto.dataPrevistaInicio = DateTime.Parse(dadosProjeto.dataPrevistaInicio, CultureInfo.CreateSpecificCulture("pt-br"));
            }

            if (!string.IsNullOrEmpty(dadosProjeto.dataPrevistaTermino))
            {
                projeto.dataPrevistaTermino = DateTime.Parse(dadosProjeto.dataPrevistaTermino, CultureInfo.CreateSpecificCulture("pt-br"));
            }

             
            using (BaseDeConhecimentoEntities contexto = new BaseDeConhecimentoEntities())
            {
                contexto.Projeto.Add(projeto);
                contexto.SaveChanges();
            }

        }

        public static List<ProjetoDTO> GetAll()
        {
            using (BaseDeConhecimentoEntities contexto = new BaseDeConhecimentoEntities())
            {
                var projetos = (from p in contexto.Projeto.AsEnumerable()
                                select new ProjetoDTO
                                {
                                     idProjeto = p.idProjeto,
                                     titulo = p.titulo,
                                     descricao = p.descricao,
                                     dataPrevistaTermino = p.dataPrevistaTermino.ToString(),
                                     dataPrevistaInicio = p.dataPrevistaInicio.ToString(),
                                     dataInicio = p.dataInicio.ToString(),
                                     dataFim = p.dataFim.ToString(),
                                     custoReal = p.custoReal.ToString(),
                                     custoPrevisto = p.custoPrevisto.ToString()

                                }).ToList();

                return projetos;
            }

            return new List<ProjetoDTO>();
        }


    }
}