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
    public class PreglediController : Controller
    {
        private VeterinaryStationContext db = new VeterinaryStationContext();
        [Autorizacija(KorisnickeUloge.Doktor)]
        // GET: ModulDoktor/Pregledi
        public ActionResult Index()
        {
            var pregledi = db.Pregledii;
            return View(pregledi.ToList());
        }
        public ActionResult Create()
        {
            Pregled model = new Pregled
            {
                listaDoktora = db.Doktori.ToList(),
                listaPacijenata = db.Pacijenti.ToList(),
                listaRacuna = db.Racunii.ToList(),
                listaPregleda = db.Pregledii.ToList()
            };
            return View(model);
        }

        // POST: ModulDoktor/Pregledi/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]

        public ActionResult Create(Pregled vm)
        {
            Pregledi p = new Pregledi();
            if (ModelState.IsValid)
            {
                p.Id = vm.Id;
                p.DatumPregleda = vm.DatumPregleda;
                p.DoktorId = vm.DoktorId;
                p.PacijentId = vm.PacijentId;
                p.RacuniId = vm.RacuniId;
                p.IsDeleted = false;

                db.Pregledii.Add(p);

                db.SaveChanges();

                TempData["Message"] = "Uspješno dodavanje!";
                return RedirectToAction("Create");
            }
            vm.listaDoktora = db.Doktori.ToList();
            vm.listaPacijenata = db.Pacijenti.ToList();
            vm.listaRacuna = db.Racunii.ToList();
            return View(vm);
        }

        // GET: ModulDoktor/Pregledi/Edit/5
        public ActionResult Edit(int? id)
        {
            Pregled model = db.Pregledii.Where(x => x.Id == id).Select(z => new Pregled()
            {
                Id = z.Id,
                IsDeleted = z.IsDeleted,
                DatumPregleda = z.DatumPregleda,
                DoktorId = z.DoktorId,
                PacijentId = z.PacijentId,
                RacuniId = z.RacuniId,
                listaDoktora = db.Doktori.ToList(),
                listaPacijenata = db.Pacijenti.ToList(),
                listaRacuna = db.Racunii.ToList(),

            }).Single();
            return View(model);
        }

        // POST: ModulDoktor/Pregledi/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]

        public ActionResult Edit(Pregled vm)
        {

            Pregledi a = new Pregledi();
            if (ModelState.IsValid)
            {
                a = db.Pregledii.Find(vm.Id);
                a.Id = vm.Id;
                a.DatumPregleda = vm.DatumPregleda;
                a.DoktorId = vm.DoktorId;
                a.PacijentId = vm.PacijentId;
                a.RacuniId = vm.RacuniId;
                a.IsDeleted = false;

                db.SaveChanges();

                TempData["Message"] = "Uspješna izmjena!";
                return RedirectToAction("Edit");
            }
            vm.listaDoktora = db.Doktori.ToList();
            vm.listaPacijenata = db.Pacijenti.ToList();
            vm.listaRacuna = db.Racunii.ToList();
            return View(vm);
        }
        public ActionResult Delete()
        {
            Pregled model = new Pregled();
            model.listaPregleda = db.Pregledii.Where(x => x.IsDeleted == false).ToList();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Obrisi(int id)
        {
            if (db.Pregledii.SingleOrDefault(x => x.Id == id) != null)
            {
                db.UspostavljenaDijagnoze.Remove(db.UspostavljenaDijagnoze.FirstOrDefault(x => x.PreglediId == id));
                db.Pregledii.Remove(db.Pregledii.FirstOrDefault(x => x.Id == id));
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