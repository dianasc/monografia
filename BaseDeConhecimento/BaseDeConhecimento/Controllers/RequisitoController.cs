using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseDeConhecimento.Dtos;
using BaseDeConhecimento.Models;

namespace BaseDeConhecimento.Controllers
{
    public class RequisitoController : Controller
    {
        //
        // GET: /Requisito/

        public ActionResult Index(int id)
        {
            ViewBag.idProjeto = id;
            return View(RequisitoBO.GetRequisitosPorProjeto(id));
        }

        public ActionResult Cadastrar(int id)
        {
            ViewBag.idProjeto = id;
            return View();
        }


        public ActionResult Salvar(FormCollection dadosRequisito)
        {
            //ViewBag.idProjeto = id;
            RequisitoDTO requisitoDto = new RequisitoDTO()
            {
                bugs = dadosRequisito["bugs"],
                qtdComunicacaoExterna = dadosRequisito["qtdComunicacaoExterna"],
                nome = dadosRequisito["nome"],
                descricao = dadosRequisito["descricao"],
                idProjeto = int.Parse(dadosRequisito["hdIdProjeto"]),
                criterioAceitacao = dadosRequisito["criterioAceitacao"]
            };

            if (string.IsNullOrEmpty(dadosRequisito["idRequisito"]))
            {
                RequisitoBO.Salvar(requisitoDto);
                ViewBag.Destino = string.Concat(HttpContext.Request.Url.Scheme,"://",HttpContext.Request.Url.Authority, "/Requisito/Index/",requisitoDto.idProjeto);
                return View("Sucesso");
            }
            else
            {
                requisitoDto.idRequisito = int.Parse(dadosRequisito["idRequisito"]);
                RequisitoBO.Editar(requisitoDto);
                return RedirectToAction("Index", "Requisito", new { id = requisitoDto.idProjeto });
            }
        }

        public ActionResult Editar(int id)
        {
            return View(RequisitoBO.GetRequisito(id));
        }

    }
}
