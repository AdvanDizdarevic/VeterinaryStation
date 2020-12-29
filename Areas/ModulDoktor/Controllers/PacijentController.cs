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
    public class PacijentController : Controller
    {
        private VeterinaryStationContext db = new VeterinaryStationContext();
        [Autorizacija(KorisnickeUloge.Doktor)]

        // GET: ModulDoktor/Pacijent
        public ActionResult Index()
        {
            var pacijenti = db.Pacijenti;
            return View(pacijenti.ToList());

        }
        public ActionResult Create()
        {
            Pacijenti model = new Pacijenti
            {
                listaVlasnika = db.Vlasnici.ToList(),
                listaVrsta = db.Vrste.ToList(),
                listaPacijenata = db.Pacijenti.ToList()
            };
            return View(model);
        }

        // POST: ModulDoktor/Pacijent/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]

        public ActionResult Create(Pacijenti vm)
        {
            Pacijent p = new Pacijent();
            if (ModelState.IsValid)
            {
                p.Id = vm.Id;
                p.Ime = vm.Ime;
                p.Godiste = vm.Godiste;
                p.DatumPrijema = vm.DatumPrijema;
                p.VlasnikId = vm.VlasnikId;
                p.VrstaId = vm.VrstaId;
                p.IsDeleted = false;
                
                db.Pacijenti.Add(p);

                db.SaveChanges();

                TempData["Message"] = "Uspješno dodavanje!";
                return RedirectToAction("Create");
            }
            vm.listaVlasnika = db.Vlasnici.ToList();
            vm.listaVrsta = db.Vrste.ToList();
            return View(vm);
        }

        // GET: ModulDoktor/Pacijent/Edit/5
        public ActionResult Edit(int? id)
        {
            Pacijenti model = db.Pacijenti.Where(x => x.Id == id).Select(z => new Pacijenti()
            {
                Id = z.Id,
                VlasnikId = z.VlasnikId,
                VrstaId = z.VrstaId,
                IsDeleted = z.IsDeleted,
                Ime = z.Ime,
                Godiste = z.Godiste,
                DatumPrijema = z.DatumPrijema,
                listaVlasnika = db.Vlasnici.ToList(),
                listaVrsta = db.Vrste.ToList(),

            }).Single();
            return View(model);
        }

        // POST: ModulDoktor/Pacijent/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]

        public ActionResult Edit(Pacijenti vm)
        {

            Pacijent a;
            if (ModelState.IsValid)
            {
                a = db.Pacijenti.Find(vm.Id);
                a.Id = vm.Id;
                a.Ime = vm.Ime;
                a.Godiste = vm.Godiste;
                a.DatumPrijema = vm.DatumPrijema;
                a.VlasnikId = vm.VlasnikId;
                a.VrstaId = vm.VrstaId;
                a.IsDeleted = false;

                db.SaveChanges();
                
                TempData["Message"] = "Uspješna izmjena!";
                return RedirectToAction("Edit");
            }
            vm.listaVlasnika = db.Vlasnici.ToList();
            vm.listaVrsta = db.Vrste.ToList();
            return View(vm);
        }
        public ActionResult Delete()
        {
            Pacijenti model = new Pacijenti();
            model.listaPacijenata = db.Pacijenti.Where(x => x.IsDeleted == false).ToList();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Obrisi(int id)
        {
            if (db.Pacijenti.SingleOrDefault(x => x.Id == id) != null)
            {
                db.Pacijenti.Remove(db.Pacijenti.FirstOrDefault(x => x.Id == id));

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