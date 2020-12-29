using System;
using System.ComponentModel;
using VeterinaryStation.Helper;

namespace VeterinaryStation.Models
{
    public class Racuni : IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Naziv { get; set; }
        public DateTime Datum { get; set; }
        [DisplayName("Iznos za platiti")]
        public string IznosZaPlatiti { get; set; }
    }
}
