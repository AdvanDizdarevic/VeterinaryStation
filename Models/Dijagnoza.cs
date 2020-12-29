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
    public class Dijagnoza : IEntity
    {

        public int Id { get; set; }

        public bool IsDeleted { get; set; }
        [DisplayName("Naziv dijagnoze")]
        public  string Naziv_dijagnoze { get; set; }
        [DisplayName("Šifra dijagnoze")]
        public  string Sifra_dijagnoze { get; set; }
    }
    }
