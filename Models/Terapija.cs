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
    public class Terapija:IEntity {

        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public  string Vrsta { get; set; }
        [DisplayName("Datum terapije")]
        public  DateTime DatumTerapije { get; set; }




    }
}
