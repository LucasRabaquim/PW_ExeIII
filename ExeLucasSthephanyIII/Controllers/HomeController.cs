﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExeLucasSthephanyIII.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Inicio()
        {
            return View();
        }

        public ActionResult Nota()
        {
            return View();
        }

        public ActionResult CalculaNota(int? Erros)
        {
            if (Erros == null)
            {
                TempData["Nota"] = "Invalido";
                return RedirectToAction("Nota");
            }
            TempData["Nota"] = 10 - Erros;
            return View();
        }
    }
}