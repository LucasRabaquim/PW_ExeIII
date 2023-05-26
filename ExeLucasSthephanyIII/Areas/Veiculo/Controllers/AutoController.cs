using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExeLucasSthephanyIII.Models;

namespace ExeLucasSthephanyIII.Areas.Veiculo.Controllers
{
    public class AutoController : Controller
    {
        // GET: Veiculo/Auto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Moto()
        {
            Moto moto = new Moto();
            moto.Chassis = null;
            moto.Fabricante = "Ducati";
            moto.Categoria = "Sport";
            moto.Cilindrada = 988;
            moto.Transmissao = "Automática";
            return View(moto);
        }

        public ActionResult Carro()
        {
            Carro carro = new Carro
            {
                Chassis = null,
                Fabricante = "Chevrolet",
                Nome = "Coupe",
                Tipo = "Camaro",
                Transmissao = "Automática"
            };

            return View(carro);
        }

        public ActionResult Veiculo() {
            Moto moto = new Moto
            {
                Chassis = null,
                Fabricante = "Ducati",
                Categoria = "Sport",
                Cilindrada = 988,
                Transmissao = "Automática"
            };
            ViewBag.Fabricante = "Chevrolet";
            ViewBag.Nome = "Coupe";
            ViewBag.Tipo = "Camaro";
            ViewBag.Transmissao = "Automática";
            return View(moto);
        }
    }
}