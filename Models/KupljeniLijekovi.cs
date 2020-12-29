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
    public class KupljeniLijekovi : IEntity
    {

        public int Id { get; set; }

        public bool IsDeleted { get; set; }
        [DisplayName("Kolièina")]
        public  int Kolicina { get; set; }

        public Racuni Racuni { get; set; }
        [DisplayName("Raèun")]
        public int RacuniId { get; set; }

        public Lijekovi Lijekovi { get; set; }
        [DisplayName("Lijek")]
        public int LijekoviId { get; set; }



    }
}
