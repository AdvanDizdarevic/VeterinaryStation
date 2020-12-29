using VeterinaryStation.Helper;

namespace VeterinaryStation.Models
{
    public class Zvanje : IEntity
    {
        public string Naziv { get; set; }
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
