using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VeterinaryStation.Models;

namespace VeterinaryStation.Areas.ModulKorisnickiNalog.Models
{
    public class NalogDeleteVM
    {
        public List<KorisnickiNalog> listaNaloga { get; set; }
        public int KorisnickiNalogId { get; set; }

        public bool Aktivacija { get; set; }
    }
}