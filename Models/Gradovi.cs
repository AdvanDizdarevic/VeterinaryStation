using VeterinaryStation.Helper;

namespace VeterinaryStation.Models
{
    public class Gradovi : IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Naziv { get; set; }
    }
}
