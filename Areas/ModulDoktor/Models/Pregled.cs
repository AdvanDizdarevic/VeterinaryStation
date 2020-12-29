using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VeterinaryStation.Models;

namespace VeterinaryStation.Areas.ModulDoktor.Models
{
    public class Pregled
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime DatumPregleda { get; set; }

        public List<Doktor> listaDoktora { get; set; }
        public int DoktorId { get; set; }

        public List<Pacijent> listaPacijenata { get; set; }
        public int PacijentId { get; set; }

        public List<Racuni> listaRacuna { get; set; }
        public int RacuniId { get; set; }
        public List<Pregledi> listaPregleda { get; set; }
        public int PreglediId { get; set; }
    }
}