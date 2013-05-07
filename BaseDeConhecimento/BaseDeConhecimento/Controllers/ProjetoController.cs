using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseDeConhecimento.Dtos;
using BaseDeConhecimento.Models;
using System.Drawing;
using System.Globalization;
namespace BaseDeConhecimento.Controllers
{
    public class ProjetoController : Controller
    {
        //
        // GET: /Projeto/

        public ActionResult Cadastrar()
        {
            return View("Cadastrar");
        }

        public ActionResult Salvar(FormCollection dadosProjeto)
        {
            //ProjetoDTO projetoDto = new ProjetoDTO() { custoPrevisto = decimal.Parse(dadosProjeto["custoPrevisto"]), 
            //    custoReal = decimal.Parse(dadosProjeto["custoReal"]),
            //    dataFim = DateTime.Parse(dadosProjeto["dataFim"], CultureInfo.CreateSpecificCulture("pt-br")), 
            //    dataInicio = DateTime.Parse(dadosProjeto["dataFim"], CultureInfo.CreateSpecificCulture("pt-br")};

            ProjetoDTO projetoDto = new ProjetoDTO()
            {
                custoPrevisto = dadosProjeto["custoPrevisto"],
                custoReal = dadosProjeto["custoReal"],
                dataFim = dadosProjeto["dataFim"],
                dataInicio = dadosProjeto["dataInicio"],
                dataPrevistaInicio = dadosProjeto["dataPrevistaInicio"],
                dataPrevistaTermino = dadosProjeto["dataPrevistaTermino"],
                descricao = dadosProjeto["descricao"],
                titulo = dadosProjeto["titulo"]
            };

            ProjetoBO.Salvar(projetoDto);
            
            return View("Sucesso","Shared");
        }

        public ActionResult Listar()
        {
            
            return View(ProjetoBO.GetAll());
        }

    }
}
