using VeterinaryStation.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryStation.Helper;
using System.ComponentModel;

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
