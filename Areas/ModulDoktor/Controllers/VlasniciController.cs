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
    public class VlasniciController : Controller

    {
        private VeterinaryStationContext db = new VeterinaryStationContext();
        [Autorizacija(KorisnickeUloge.Doktor)]


        // GET: ModulDoktor/Vlasnici
        public ActionResult Index()
        {
            var vlasnika = db.Vlasnici;
            return View(vlasnika.ToList());

        }

        // GET: ModulDoktor/Vlasnici/Create
        public ActionResult Create()
        {
            Vlasnici model = new Vlasnici
            {
                listaVlasnika = db.Vlasnici.ToList()
            };
            return View(model);
        }

        // POST: ModulDoktor/Vlasnici/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Vlasnici vm)
        {
            Vlasnik vlasnici = new Vlasnik();
            if (ModelState.IsValid)
            {
                vlasnici.Ime = vm.Ime;
                vlasnici.Prezime = vm.Prezime;
                db.Vlasnici.Add(vlasnici);
                db.SaveChanges();

                TempData["Message"] = "Uspješno dodavanje!";
                return RedirectToAction("Create");
            }
            return View(vm);
        }

        // GET: ModulDoktor/Vlasnici/Edit/5
        public ActionResult Edit(int? id)
        {
            Vlasnici model = db.Vlasnici.Where(x => x.Id == id).Select(z => new Vlasnici()
            {
                Id = z.Id,
                Ime = z.Ime,
                Prezime = z.Prezime,
                IsDeleted = z.IsDeleted,

            }).Single();
            return View(model);
        }

        // POST: ModulDoktor/Vlasnici/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]

        public ActionResult Edit(Vlasnici vm)
        {

            Vlasnik a;
            if (ModelState.IsValid)
            {
                a = db.Vlasnici.Find(vm.Id);
                a.Id = vm.Id;
                a.Ime = vm.Ime;
                a.Prezime = vm.Prezime;
                a.IsDeleted = false;

                db.SaveChanges();

                TempData["Message"] = "Uspješna izmjena!";
                return RedirectToAction("Edit");
            }
            return View(vm);
        }
        public ActionResult Delete()
        {
            Vlasnici model = new Vlasnici();
            model.listaVlasnika = db.Vlasnici.Where(x => x.IsDeleted == false).ToList();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Obrisi(int id)
        {
            if (db.Vlasnici.SingleOrDefault(x => x.Id == id) != null)
            {
                db.Pacijenti.Remove(db.Pacijenti.FirstOrDefault(x => x.VlasnikId == id));
                db.Vlasnici.Remove(db.Vlasnici.FirstOrDefault(x => x.Id == id));    
                db.SaveChanges();

                return RedirectToAction("Delete");
            }

            return View("Delete");
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