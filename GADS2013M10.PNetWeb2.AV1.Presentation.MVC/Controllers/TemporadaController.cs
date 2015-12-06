using System.Linq;
using System.Web;
using System.Web.Mvc;
using GADS2013M10.PNetWeb2.AV1.Domain.Contexto;
using GADS2013M10.PNetWeb2.AV1.Domain.Entidades;
using System.Data.Entity;

namespace GADS2013M10.PNetWeb2.AV1.Presentation.MVC.Controllers
{
    public class TemporadaController : Controller
    {
        private INFNETGridDbContext1 db = new INFNETGridDbContext1();

        // GET: CanalTv
        public ActionResult Index()
        {
            var temporada = db.Temporadas;
            return View(temporada);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Temporada temporada)
        {
            if (ModelState.IsValid)
            {
                db.Temporadas.Add(temporada);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(temporada);
        }
    }
}