using VeterinaryStation.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using VeterinaryStation.Helper;

namespace VeterinaryStation.Models
{
    public class KorisnickiNalog : IEntity
    {
		


        public int Id { get; set; }

        public bool IsDeleted { get; set; }
       
        public  string Username { get; set; }

        public  string Password { get; set; }
      


        public virtual Administrator Administrator { get; set; }

        public virtual Doktor Doktor { get; set; }

        public virtual Tehnicko_osoblje Tehnicko_osoblje { get; set; }

        public bool? Aktivan { get; set; }

        
        public bool doc { get; set; }

        public bool teh_osob { get; set; }

        public bool admin { get; set; }

    }
}
