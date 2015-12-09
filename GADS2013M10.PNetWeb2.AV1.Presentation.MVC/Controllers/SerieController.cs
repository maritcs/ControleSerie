using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GADS2013M10.PNetWeb2.AV1.Domain.Contexto;
using GADS2013M10.PNetWeb2.AV1.Domain.Entidades;
using System.Data.Entity;
using System.Net;

namespace GADS2013M10.PNetWeb2.AV1.Presentation.MVC.Controllers
{
    public class SerieController : Controller
    {
        //private InfnetGridDbContext db = new InfnetGridDbContext();
        //private INFNETGridDbContext1 db = new INFNETGridDbContext1();
        private INFNETDbContext db = new INFNETDbContext();
        

        // GET: Serie
        public ActionResult Index()
        {
            var serie = db.Series.Include("CanaisTv").Include("Episodios").Include("Generos").Include("Paises").Include("Temporadas");
            return View(serie);
        }

        public ActionResult Detalhes(int id = 0)
        {
            Serie serie = db.Series.Find(id);
            return View(serie);
        }


        public ActionResult Adicionar()
        {
            ViewBag.PaisId = new SelectList(db.Paises, "PaisId", "Nome");
            ViewBag.GeneroId = new SelectList(db.Generos, "GeneroId", "NomeGenero");
            ViewBag.EpisodioId = new SelectList(db.Episodios, "EpisodioId", "NumEpisodio");
            ViewBag.TemporadaId = new SelectList(db.Temporadas, "TemporadaId", "NumTemp");
            ViewBag.CanalTvId = new SelectList(db.CanaisTv, "CanalTvId", "NomeCanal");
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Serie serie)
        {
            if (ModelState.IsValid)
            {
                db.Series.Add(serie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PaisId = new SelectList(db.Paises, "PaisId", "Nome", serie.PaisId);      
            ViewBag.GeneroId = new SelectList(db.Generos, "GeneroId", "NomeGenero", serie.GeneroId);
            ViewBag.EpisodioId = new SelectList(db.Episodios, "EpisodioId", "NumEpisodio", serie.EpisodioId);
            ViewBag.TemporadaId = new SelectList(db.Temporadas, "TemporadaId", "NumTemp", serie.TemporadaId);
            ViewBag.CanalTvId = new SelectList(db.CanaisTv, "CanalTvId", "NomeCanal", serie.CanalTvId);
            return View(serie);
        }

        [HttpPost]
        public string Excluir(long id)
        {
            try
            {
                Serie serie = db.Series.Find(id);
                db.Series.Remove(serie);
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
