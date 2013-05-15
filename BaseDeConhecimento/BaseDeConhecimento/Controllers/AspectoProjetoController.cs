using BaseDeConhecimento.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseDeConhecimento.Models;

namespace BaseDeConhecimento.Controllers
{
    public class AspectoProjetoController : Controller
    {
        //
        // GET: /AspectoProjeto/

        public ActionResult Index(int id)
        {
            ViewBag.idProjeto = id;
            return View(AspectoBO.getAspectosPorProjeto(id));
        }

        public ActionResult Cadastrar(int id)
        {
            ViewBag.listAspectos = AspectoDTO.SelectAspectos;

            AspectoProjetoDTO dto = new AspectoProjetoDTO() { idProjeto = id.ToString(),nomeProjeto = ProjetoBO.GetPorId(id).titulo  };
            return View(dto);
        }

        public ActionResult Salvar(FormCollection dadosAspecto)
        {
            string[] vetorIdAspecto = dadosAspecto["hdIdAspecto[]"].Split(',');
            string[] vetorValorAspecto = dadosAspecto["hdValorAspecto[]"].Split(',');
            string[] vetorPrioridade = dadosAspecto["hdPrioridade[]"].Split(',');

            List<AspectoProjetoDTO> aspectoProjeto = new List<AspectoProjetoDTO>();

            for (int i = 0; i < vetorIdAspecto.Count(); i++)
            {
                aspectoProjeto.Add(new AspectoProjetoDTO() { idProjeto = dadosAspecto["idProjeto"], idAspecto = vetorIdAspecto[i], valorAtribuido = vetorValorAspecto[i], prioridade = vetorPrioridade[i] });
            }

            
            AspectoBO.adicionarAspectoPorProjeto(aspectoProjeto);
            ViewBag.Destino = string.Concat(HttpContext.Request.Url.Scheme, "://", HttpContext.Request.Url.Authority, "/AspectoProjeto/Index/", int.Parse(dadosAspecto["idProjeto"]));
            return View("Sucesso");
        }
    }
}
