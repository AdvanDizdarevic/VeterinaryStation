using System.Linq;
using System.Web.Mvc;
using VeterinaryStation.DAL;
using VeterinaryStation.Helper;
using VeterinaryStation.Models;

namespace VeterinaryStation.Areas.ModulLogin.Controllers
{
    public class LoginController : Controller
    {
        private VeterinaryStationContext ctx = new VeterinaryStationContext();
        // GET: ModulLogin/Login
        public ActionResult Index()
        {
            return Redirect("Login");
        }
        public ActionResult Login()
        {
            return View();
        }


        public ActionResult Provjera(string username, string password)
        {
            //    string hashPass = MD5Hash.GetMD5Hash(password);
            //KorisnickiNalog k = new KorisnickiNalog()
            //{
            //    Username = "advan",
            //    Password = "advan",
            //    IsDeleted = false,
            //    admin = true,
            //    Aktivan = true
            //};

            KorisnickiNalog k = ctx.KorisnickiNalozi.SingleOrDefault(x => x.Username == username && x.Password == password);

            if (k == null)
            {
                TempData["Message"] = "Pogrešno korisničko ime ili lozinka!";
                return Redirect("Login");
            }

            if (k.admin == true)
            {
                Autentifikacija.PokreniNovuSesiju(k, HttpContext);

                return Redirect("/ModulAdmin/Administrator/Home"); // ModulAdmin/Admin/Pregled
            }

            if (k.doc == true)
            {
                Autentifikacija.PokreniNovuSesiju(k, HttpContext);

                return Redirect("/ModulDoktor/Doktor/Home"); // ModulDoktor/Doktor/Pregled
            }

            if (k.teh_osob == true)
            {
                Autentifikacija.PokreniNovuSesiju(k, HttpContext);

                return Redirect("/ModulTehnickoOsoblje/TehnickoOsoblje/Home"); // ModulDoktor/Doktor/Pregled
            }

            return Redirect("Login");

        }

        public ActionResult Logout()
        {
            Autentifikacija.PokreniNovuSesiju(null, HttpContext);
            return RedirectToAction("Login");
        }
    }
}