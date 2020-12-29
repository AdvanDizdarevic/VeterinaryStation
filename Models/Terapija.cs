using System;
using System.ComponentModel;
using VeterinaryStation.Helper;

namespace VeterinaryStation.Models
{
    public class Terapija : IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Vrsta { get; set; }
        [DisplayName("Datum terapije")]
        public DateTime DatumTerapije { get; set; }
    }
}
