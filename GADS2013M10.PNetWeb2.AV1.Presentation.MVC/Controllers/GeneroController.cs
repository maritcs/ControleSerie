﻿using System.Linq;
using System.Web;
using System.Web.Mvc;
using GADS2013M10.PNetWeb2.AV1.Domain.Contexto;
using GADS2013M10.PNetWeb2.AV1.Domain.Entidades;
using System.Data.Entity;
using System;

namespace GADS2013M10.PNetWeb2.AV1.Presentation.MVC.Controllers
{
    public class GeneroController : Controller
    {
        //private INFNETGridDbContext1 db = new INFNETGridDbContext1();
        private INFNETDbContext db = new INFNETDbContext();

        // GET: CanalTv
        public ActionResult Index()
        {
            var genero = db.Generos;
            return View(genero);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Genero genero)
        {
            if (ModelState.IsValid)
            {
                db.Generos.Add(genero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(genero);
        }
        [HttpPost]
        public string Excluir(long id)
        {
            try
            {
                Genero genero = db.Generos.Find(id);
                db.Generos.Remove(genero);
                db.SaveChanges();
                return Boolean.TrueString;
            }
            catch
            {
                return Boolean.FalseString;
            }
        }
    }
}