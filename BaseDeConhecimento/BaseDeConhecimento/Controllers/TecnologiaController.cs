using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseDeConhecimento.Dtos;
using BaseDeConhecimento.Models;

namespace BaseDeConhecimento.Controllers
{
    public class TecnologiaController : Controller
    {
        //
        // GET: /Tecnologia/

        public ActionResult Index()
        {
            return View(TecnologiaBO.GetAll());
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        public ActionResult Salvar(FormCollection dadosProjeto)
        {
            TecnologiaDto tecnologiaDto = new TecnologiaDto() { nome = dadosProjeto["nome"] };
            TecnologiaBO.Salvar(tecnologiaDto);

            return View("Sucesso");
        }

    }
}
