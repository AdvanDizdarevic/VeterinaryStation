using VeterinaryStation.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryStation.Helper;
using System.ComponentModel;

namespace VeterinaryStation.Models
{

    public class Pregledi:IEntity
    {
        internal List<Pacijent> listaPacijenata;
        internal List<Doktor> listaDoktora;
        internal List<Racuni> listaRacuna;

        public int Id { get; set; }

        public bool IsDeleted { get; set; }
        [DisplayName("Datum pregleda")]
        public  DateTime DatumPregleda { get; set; }

        public Doktor Doktori { get; set; }
        [DisplayName("Doktor")]
        public int DoktorId { get; set; }

        public Pacijent Pacijent { get; set; }
        [DisplayName("Pacijent")]
        public int PacijentId { get; set; }

        public Racuni Racuni { get; set; }
        [DisplayName("Raèun")]
        public int RacuniId { get; set; }


    }
}
