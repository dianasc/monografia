using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseDeConhecimento.Models;
using BaseDeConhecimento.Dtos;

namespace BaseDeConhecimento.Controllers
{
    public class ColaboradorController : Controller
    {
        //
        // GET: /Colaborador/

        public ActionResult Index()
        {
            return View(ColaboradorBO.GetAll());
        }

        public ActionResult Cadastrar()
        {
            return View();
        }


        public ActionResult Salvar(FormCollection dadosUsuario)
        {
            ColaboradorDTO colaboradorDto = new ColaboradorDTO()
            {
                email = dadosUsuario["email"],
                nome = dadosUsuario["nome"]
            };

            ColaboradorBO.Salvar(colaboradorDto);
            return View("Sucesso");
        }

    }
}
