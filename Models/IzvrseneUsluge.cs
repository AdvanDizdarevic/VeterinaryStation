using System.ComponentModel;
using VeterinaryStation.Helper;

namespace VeterinaryStation.Models
{
    public class IzvrseneUsluge : IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public Racuni Racuni { get; set; }
        [DisplayName("Raèun")]
        public int RacuniId { get; set; }
        public Usluge Usluge { get; set; }
        [DisplayName("Usluge")]
        public int UslugeId { get; set; }
    }
}
