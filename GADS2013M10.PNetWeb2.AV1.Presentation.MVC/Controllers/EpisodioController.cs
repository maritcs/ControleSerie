using System.Linq;
using System.Web;
using System.Web.Mvc;
using GADS2013M10.PNetWeb2.AV1.Domain.Contexto;
using GADS2013M10.PNetWeb2.AV1.Domain.Entidades;
using System.Data.Entity;
using System;

namespace GADS2013M10.PNetWeb2.AV1.Presentation.MVC.Controllers
{
    public class EpisodioController : Controller
    {
        //private INFNETGridDbContext1 db = new INFNETGridDbContext1();
        private INFNETDbContext db = new INFNETDbContext();

        // GET: CanalTv
        public ActionResult Index()
        {
            var episodio = db.Episodios;
            return View(episodio);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Episodio episodio)
        {
            if (ModelState.IsValid)
            {
                db.Episodios.Add(episodio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(episodio);
        }

        [HttpPost]
        public string Excluir(long id)
        {
            try
            {
                Episodio episodio = db.Episodios.Find(id);
                db.Episodios.Remove(episodio);
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