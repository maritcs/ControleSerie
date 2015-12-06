using System.Linq;
using System.Web;
using System.Web.Mvc;
using GADS2013M10.PNetWeb2.AV1.Domain.Contexto;
using GADS2013M10.PNetWeb2.AV1.Domain.Entidades;
using System.Data.Entity;
using System;

namespace GADS2013M10.PNetWeb2.AV1.Presentation.MVC.Controllers
{
    public class CanalTvController : Controller
    {
        //private INFNETGridDbContext1 db = new INFNETGridDbContext1();
        private INFNETDbContext db = new INFNETDbContext();

        // GET: CanalTv
        public ActionResult Index()
        {
            var canalTv = db.CanaisTv;
            return View(canalTv);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(CanalTv canalTv)
        {
            if (ModelState.IsValid)
            {
                db.CanaisTv.Add(canalTv);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(canalTv);
        }

        [HttpPost]
        public string Excluir(long id)
        {
            try
            {
                CanalTv canalTv = db.CanaisTv.Find(id);
                db.CanaisTv.Remove(canalTv);
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