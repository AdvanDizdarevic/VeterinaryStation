using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using VeterinaryStation.Models;
using VeterinaryStation.Helper;

namespace VeterinaryStation.Helper
{
    public class Autorizacija : FilterAttribute, IAuthorizationFilter
    {
        private readonly KorisnickeUloge[] _dozvoljeneUloge;

        public Autorizacija(params KorisnickeUloge[] dozvoljeneUloge)
        {
            _dozvoljeneUloge = dozvoljeneUloge;
        }

        public void OnAuthorization(AuthorizationContext filterContext)
        {
            KorisnickiNalog k = Autentifikacija.GetLogiraniKorisnik(filterContext.HttpContext);

            if (k == null)
            {
                filterContext.HttpContext.Response.Redirect("/ModulLogin/Login/Login");
                return;
            }

            //provjera
            foreach (KorisnickeUloge x in _dozvoljeneUloge)
            {
                if (x == KorisnickeUloge.Administrator && k.admin != false)
                    return;
                if (x == KorisnickeUloge.Doktor && k.doc != false)
                    return;
                if (x == KorisnickeUloge.Tehnicko_osoblje && k.teh_osob != null)
                    return;
            }
            //ako funkcija nije prekinuta pomoću "return", onda korisnik nema pravo pistupa pa će se vršiti redirekcija na "/Home/Index"
            filterContext.HttpContext.Response.Redirect("/");
        }
    }
    public enum KorisnickeUloge
    {
        Tehnicko_osoblje,
        Doktor,
        Administrator
    }
}
