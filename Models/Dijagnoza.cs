using System.ComponentModel;
using VeterinaryStation.Helper;

namespace VeterinaryStation.Models
{
    public class Dijagnoza : IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        [DisplayName("Naziv dijagnoze")]
        public string Naziv_dijagnoze { get; set; }
        [DisplayName("Šifra dijagnoze")]
        public string Sifra_dijagnoze { get; set; }
    }
}
