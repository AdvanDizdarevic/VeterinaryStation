using VeterinaryStation.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryStation.Helper;
namespace VeterinaryStation.Models
{

    public class Zvanje:IEntity {

        public  string Naziv { get; set; }

        public int Id { get; set; }

        public bool IsDeleted { get; set; }
        
    }
}
