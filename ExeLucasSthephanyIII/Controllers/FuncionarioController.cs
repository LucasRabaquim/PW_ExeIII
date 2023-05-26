using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExeLucasSthephanyIII.Models;

namespace ExeLucasSthephanyIII.Controllers
{
    public class FuncionarioController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            Funcionario funcionario = new Funcionario();
            return View(funcionario);
        }

        [HttpPost]
        public ActionResult SelectFuncionario(FormCollection form)
        {
            ViewBag.Codigo = form["Codigo"];
            ViewBag.Nome = form["Nome"];
            ViewBag.Funcao = form["Funcao"];
            if (ViewBag.Codigo == "")
                TempData["campo"] = "Código";
            else if (ViewBag.Nome == "")
                TempData["campo"] = "Nome";
            else if (ViewBag.Funcao == "")
                TempData["campo"] = "Função";
            if (TempData["campo"] != null)
                return RedirectToAction("Cadastro");
            else
                return View();
        }

    }
}