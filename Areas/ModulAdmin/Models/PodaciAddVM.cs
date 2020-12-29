using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VeterinaryStation.Areas.ModulAdmin.Models
{
    public class PodaciAddVM
    {
        [Required(ErrorMessage = "Obavezno polje")]
        public string Naziv { get; set; }
    }
}