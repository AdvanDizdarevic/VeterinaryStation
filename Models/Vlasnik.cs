using VeterinaryStation.Helper;

namespace VeterinaryStation.Models
{
    public class Vlasnik : IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
    }
}
