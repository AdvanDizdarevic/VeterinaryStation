using VeterinaryStation.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryStation.Helper;
using VeterinaryStation.Areas.ModulDoktor.Models;
using System.ComponentModel;

namespace VeterinaryStation.Models
{
    public class Lijekovi : IEntity
    {


        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public  string Naziv { get; set; }

        public  string Vrsta { get; set; }
        [DisplayName("Rok trajanja")]
        public  DateTime Rok_trajanja { get; set; }

    }
}
