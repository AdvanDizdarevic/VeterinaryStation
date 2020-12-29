using System.Web.Mvc;
using VeterinaryStation.Areas.ModulAdmin.Models;
using VeterinaryStation.DAL;
using VeterinaryStation.Helper;
using VeterinaryStation.Models;

namespace VeterinaryStation.Areas.ModulAdmin.Controllers
{
    [Autorizacija(KorisnickeUloge.Administrator)]
    public class GradoviController : Controller
    {
        private VeterinaryStationContext db = new VeterinaryStationContext();

        // GET: ModulAdmin/Gradovi/Create
        public ActionResult Create()
        {
            PodaciAddVM model = new PodaciAddVM();
            return View("Create", model);
        }

        // POST: ModulAdmin/Gradovi/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(PodaciAddVM vm)
        {

            Gradovi gradovi = new Gradovi();
            if (ModelState.IsValid)
            {
                gradovi.Naziv = vm.Naziv;

                db.Gradovii.Add(gradovi);
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
