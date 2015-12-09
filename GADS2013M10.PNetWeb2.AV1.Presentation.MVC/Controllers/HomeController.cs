using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GADS2013M10.PNetWeb2.AV1.Domain.Entidades;
using GADS2013M10.PNetWeb2.AV1.Domain.Contexto;

namespace GADS2013M10.PNetWeb2.AV1.Presentation.MVC.Controllers
{
    public class HomeController : Controller
    {
        private INFNETDbContext db = new INFNETDbContext();

        public ActionResult Index()
        {
         
            ViewBag.CanalTv = new SelectList(db.CanaisTv, "CanalTvId", "NomeCanal");

            return View();
        }

        public ActionResult Pesquisar(Pesquisa pesquisa)
        {
            var serie = from m in db.Series
                          where m.CanalTvId == pesquisa.CanalTvId
                          select new ResultadoPesquisa {NomeSerie = m.NomeSerie};

            return Json(serie, JsonRequestBehavior.AllowGet);
        }
    }
}