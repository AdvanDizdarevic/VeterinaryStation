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

    public class Uplata:IEntity {

        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public  string Iznos { get; set; }

        public  DateTime Datum { get; set; }

        public Racuni Racuni { get; set; }
        [DisplayName("Raèun")]
        public int RacuniId { get; set; }

    }
}
