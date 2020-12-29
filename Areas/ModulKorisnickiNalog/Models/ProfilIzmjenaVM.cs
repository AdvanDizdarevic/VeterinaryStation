using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VeterinaryStation.Areas.ModulKorisnickiNalog.Models
{
    public class ProfilIzmjenaVM
    {
        [Required(ErrorMessage = "Obavezno polje!")]
        public string StariPassword { get; set; }

        [Required(ErrorMessage = "Obavezno polje!")]
        public string NoviPassword { get; set; }
    }
}