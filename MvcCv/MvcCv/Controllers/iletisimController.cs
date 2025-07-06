using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;
namespace MvcCv.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim
        GenericRepository<Tblilerisim> repo = new GenericRepository<Tblilerisim>();
        public ActionResult Index()
        {
            var mesaj = repo.List();
            return View(mesaj);
        }
        public ActionResult MesajSil(int id)
        {
            var mesaj = repo.Find(x => x.ID == id);
            repo.TDelete(mesaj);
            return RedirectToAction("Index");
        }
    }
}