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

    public class Pacijent : IEntity
    {
        internal List<Vlasnik> listaVlasnika;
        internal List<Gradovi> listaGradova;

        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public  string Ime { get; set; }
        [DisplayName("Godište")]
        public  DateTime Godiste { get; set; }
        [DisplayName("Datum prijema")]
        public  DateTime DatumPrijema { get; set; }

        public Vlasnik Vlasnik { get; set; }
        public Vrsta Vrsta { get; set; }
        [DisplayName("Vlasnik")]
        public int VlasnikId { get; set; }
        [DisplayName("Vrsta")]
        public int VrstaId { get; set; }



    }
}
