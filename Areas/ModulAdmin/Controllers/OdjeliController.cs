using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VeterinaryStation.Areas.ModulAdmin.Models;
using VeterinaryStation.DAL;
using VeterinaryStation.Helper;
using VeterinaryStation.Models;

namespace VeterinaryStation.Areas.ModulAdmin.Controllers
{
    [Autorizacija(KorisnickeUloge.Administrator)]
    public class OdjeliController : Controller
    {
        private VeterinaryStationContext db = new VeterinaryStationContext();



        // GET: ModulAdmin/Odjeli/Create
        public ActionResult Create()
        {
            PodaciAddVM model = new PodaciAddVM();  
            return View("Create",model);
        }

        // POST: ModulAdmin/Odjeli/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( PodaciAddVM vm)
        {
            Odjeli odjeli  = new Odjeli();
            if (ModelState.IsValid) {
                odjeli.Naziv = vm.Naziv;
                db.Odjelii.Add(odjeli);
                db.SaveChanges();

            TempData["Message"] = "Uspjesno dodavanje!";
            return RedirectToAction("Create");
        }
            return View(vm);
    }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
