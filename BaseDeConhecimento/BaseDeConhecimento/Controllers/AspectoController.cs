using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseDeConhecimento.Dtos;
using BaseDeConhecimento.Models;
namespace BaseDeConhecimento.Controllers
{
    public class AspectoController : Controller
    {
        //
        // GET: /Aspecto/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        public ActionResult Salvar(FormCollection dadosAspecto)
        {
            AspectoDTO aspectoDto = new AspectoDTO()
            {
                descricao = dadosAspecto["descricao"],
                codigoIdentificacao = dadosAspecto["codigoIdentificacao"],
                tipo = dadosAspecto["tipo"],
                peso = dadosAspecto["peso"]
            };

            AspectoBO.Salvar(aspectoDto);
            return View("Sucesso");
        }

    }
}
