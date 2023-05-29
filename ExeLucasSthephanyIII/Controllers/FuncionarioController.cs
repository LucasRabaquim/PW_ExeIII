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
        public ActionResult SelectFuncionario(string codigo, string nome, string funcao)
        {
            
            if (codigo == "")
                TempData["campo"] = "Código";
            else if (nome == "")
                TempData["campo"] = "Nome";
            else if (funcao == "")
                TempData["campo"] = "Função";
            if (TempData["campo"] != null)
                return RedirectToAction("Cadastro");

            Funcionario func = new Funcionario(){ 
            Codigo = Convert.ToInt32(codigo),
            Nome = nome,
            Funcao = funcao
            };
            return View(func);
        }

    }
}