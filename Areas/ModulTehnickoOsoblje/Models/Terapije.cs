using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VeterinaryStation.Models;

namespace VeterinaryStation.Areas.ModulTehnickoOsoblje.Models
{
    public class Terapije
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public string Vrsta { get; set; }

        public DateTime DatumTerapije { get; set; }

        public List<Terapija> listaTerapija { get; set; }
        public int TerapijaId { get; set; }

    }
}