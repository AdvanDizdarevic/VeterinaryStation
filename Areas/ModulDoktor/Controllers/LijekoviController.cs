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
    public class LijekoviController : Controller
    {
        private VeterinaryStationContext db = new VeterinaryStationContext();
        [Autorizacija(KorisnickeUloge.Doktor)]
        // GET: ModulDoktor/Lijekovi
        public ActionResult Index()
        {
            var lijekovi = db.Lijekovii;
            return View(lijekovi.ToList());
        }
        public ActionResult Create()
        {
            Lijek model = new Lijek
            {
                listaLijekova = db.Lijekovii.ToList(),
            };
            return View(model);
        }

        // POST: ModulDoktor/Lijekovi/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]

        public ActionResult Create(Lijek vm)
        {
            Lijekovi p = new Lijekovi();
            if (ModelState.IsValid)
            {
                p.Id = vm.Id;
                p.Naziv = vm.Naziv;
                p.Vrsta = vm.Vrsta;
                p.Rok_trajanja = vm.Rok_trajanja;
                p.IsDeleted = false;

                db.Lijekovii.Add(p);

                db.SaveChanges();

                TempData["Message"] = "Uspješno dodavanje!";
                return RedirectToAction("Create");
            }
            return View(vm);
        }

        // GET: ModulDoktor/Lijekovi/Edit/5
        public ActionResult Edit(int? id)
        {
            Lijek model = db.Lijekovii.Where(x => x.Id == id).Select(z => new Lijek()
            {
                Id = z.Id,
                IsDeleted = z.IsDeleted,
                Naziv = z.Naziv,
                Vrsta = z.Vrsta,
                Rok_trajanja = z.Rok_trajanja,

            }).Single();
            return View(model);
        }

        // POST: ModulDoktor/Lijekovi/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]

        public ActionResult Edit(Lijek vm)
        {

            Lijekovi a = new Lijekovi();
            if (ModelState.IsValid)
            {
                a = db.Lijekovii.Find(vm.Id);
                a.Id = vm.Id;
                a.Naziv = vm.Naziv;
                a.Vrsta = vm.Vrsta;
                a.Rok_trajanja = vm.Rok_trajanja;
                a.IsDeleted = false;

                db.SaveChanges();

                TempData["Message"] = "Uspješna izmjena!";
                return RedirectToAction("Edit");
            }
            return View(vm);
        }
        public ActionResult Delete()
        {
            Lijek model = new Lijek();
            model.listaLijekova = db.Lijekovii.Where(x => x.IsDeleted == false).ToList();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Obrisi(int id)
        {
            if (db.Lijekovii.SingleOrDefault(x => x.Id == id) != null)
            {
                db.Lijekovii.Remove(db.Lijekovii.FirstOrDefault(x => x.Id == id));

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