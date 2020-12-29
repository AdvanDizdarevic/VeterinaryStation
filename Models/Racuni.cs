using VeterinaryStation.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryStation.Helper;
using VeterinaryStation.Helper;
using System.ComponentModel;

namespace VeterinaryStation.Models
{

    public class Racuni:IEntity{

        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public  string Naziv { get; set; }
        public  DateTime Datum { get; set; }
        [DisplayName("Iznos za platiti")]
        public  string IznosZaPlatiti { get; set; }

    }
}
