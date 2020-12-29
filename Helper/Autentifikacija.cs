 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VeterinaryStation.DAL;
using VeterinaryStation.Models;

namespace VeterinaryStation.Helper
{
    public class Autentifikacija
    {
        public const string LogiraniKorisnik = "logirani_korisnik";

        public static void PokreniNovuSesiju(KorisnickiNalog korisnik, HttpContextBase context)
        {
            context.Session.Add(LogiraniKorisnik, korisnik);
        }

        public static KorisnickiNalog GetLogiraniKorisnik(HttpContextBase context)
        {
            return (KorisnickiNalog)context.Session[LogiraniKorisnik];
        }
    }
}