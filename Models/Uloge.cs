using System.ComponentModel;
using VeterinaryStation.Helper;

namespace VeterinaryStation.Models
{
    public class Uloge : IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        [DisplayName("Naziv uloge")]
        public string NazivUloge { get; set; }
    }
}