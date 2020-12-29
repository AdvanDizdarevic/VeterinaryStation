using System;
using System.ComponentModel;
using VeterinaryStation.Helper;

namespace VeterinaryStation.Models
{
    public class Usluge : IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Naziv { get; set; }
        [DisplayName("Datum usluge")]
        public DateTime DatumUsluge { get; set; }
    }
}
