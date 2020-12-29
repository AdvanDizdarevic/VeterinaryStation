using System;
using System.ComponentModel;
using VeterinaryStation.Helper;

namespace VeterinaryStation.Models
{
    public class Lijekovi : IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Naziv { get; set; }
        public string Vrsta { get; set; }
        [DisplayName("Rok trajanja")]
        public DateTime Rok_trajanja { get; set; }
    }
}
