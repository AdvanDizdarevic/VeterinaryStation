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

    public class UspostavljenaDijagnoza:IEntity
    {
        internal List<Dijagnoza> listaDijagnoza;
        internal List<Pregledi> listaPregleda;

        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public  int Intezitet { get; set; }

        public  string Komentar { get; set; }

        public virtual Dijagnoza Dijagnoze { get; set; }
        [DisplayName("Dijagnoza")]
        public int DijagnozaId { get; set; }
        public virtual Pregledi Pregledi { get; set; }
        [DisplayName("Pregledi")]
        public int PreglediId { get; set; }


    }
}
