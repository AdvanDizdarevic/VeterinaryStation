using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VeterinaryStation.Areas.ModulAdmin.Models;
using VeterinaryStation.Areas.ModulDoktor.Models;
using VeterinaryStation.Areas.ModulKorisnickiNalog.Models;
using VeterinaryStation.DAL;
using VeterinaryStation.Helper;
using VeterinaryStation.Models;

namespace VeterinaryStation.Areas.ModulDoktor.Controllers
{
    [Autorizacija(KorisnickeUloge.Doktor)]
    public class VrstaController : Controller
    {
        private VeterinaryStationContext db = new VeterinaryStationContext();
        [Autorizacija(KorisnickeUloge.Doktor)]

        // GET: ModulDoktor/Vrsta
        public ActionResult Index()
        {
            var vrsta = db.Vrste;
            return View(vrsta.ToList());

        }
        public ActionResult Create()
        {
            Vrste model = new Vrste
            {
                listaVrsta = db.Vrste.ToList()
            };
            return View(model);
        }

        // POST: ModulDoktor/Vrsta/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]

        public ActionResult Create(Vrste vm)
        {
            Vrsta p = new Vrsta();
            if (ModelState.IsValid)
            {
                p.Id = vm.Id;
                p.Naziv = vm.Naziv;
                p.IsDeleted = false;

                db.Vrste.Add(p);

                db.SaveChanges();

                TempData["Message"] = "Uspješno dodavanje!";
                return RedirectToAction("Create");
            }
            return View(vm);
        }

        // GET: ModulDoktor/Vrsta/Edit/5
        public ActionResult Edit(int? id)
        {
            Vrste model = db.Vrste.Where(x => x.Id == id).Select(z => new Vrste()
            {
                Id = z.Id,
                Naziv = z.Naziv,
                IsDeleted = z.IsDeleted,

            }).Single();
            return View(model);
        }

        // POST: ModulDoktor/Vrsta/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]

        public ActionResult Edit(Vrste vm)
        {

            Vrsta a;
            if (ModelState.IsValid)
            {
                a = db.Vrste.Find(vm.Id);
                a.Id = vm.Id;
                a.Naziv = vm.Naziv;
                a.IsDeleted = false;

                db.SaveChanges();

                TempData["Message"] = "Uspješna izmjena!";
                return RedirectToAction("Edit");
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