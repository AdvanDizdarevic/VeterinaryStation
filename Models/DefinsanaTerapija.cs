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

    public class DefinsanaTerapija : IEntity
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public  int Doziranje { get; set; }

        public virtual Pregledi Pregledi { get; set; }
        [DisplayName("Pregled")]
        public int PreglediId { get; set; }

        public virtual Terapija Terapija { get; set; }
        [DisplayName("Terapija")]
        public int TerapijaId { get; set; }

    }
}
