using VeterinaryStation.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryStation.Helper;
namespace VeterinaryStation.Models
{
    public class Doktor : IEntity
    {

        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public  string Pozicija { get; set; }

        public  string Ime { get; set; }

        public  string Prezime { get; set; }

        public virtual Gradovi Gradovi { get; set; }

        public virtual KorisnickiNalog KorisnickiNalog { get; set; }

        public  Zvanje Zvanje { get; set; }

        public int? GradoviId { get; set; }

        public int? ZvanjeId { get; set; }

        public int KorisnickiNalogId { get; set; }



    }
}
