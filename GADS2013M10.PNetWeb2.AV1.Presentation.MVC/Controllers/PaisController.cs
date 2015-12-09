using System.Linq;
using System.Web;
using System.Web.Mvc;
using GADS2013M10.PNetWeb2.AV1.Domain.Contexto;
using GADS2013M10.PNetWeb2.AV1.Domain.Entidades;
using System.Data.Entity;
using System;

namespace GADS2013M10.PNetWeb2.AV1.Presentation.MVC.Controllers
{
    public class PaisController : Controller
    {
        //private INFNETGridDbContext1 db = new INFNETGridDbContext1();
        private INFNETDbContext db = new INFNETDbContext();

        // GET: CanalTv
        public ActionResult Index()
        {
            var pais = db.Paises;
            return View(pais);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Pais pais)
        {
            if (ModelState.IsValid)
            {
                db.Paises.Add(pais);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pais);
        }
        [HttpPost]
        public string Excluir(long id)
        {
            try
            {
                Pais pais = db.Paises.Find(id);
                db.Paises.Remove(pais);
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