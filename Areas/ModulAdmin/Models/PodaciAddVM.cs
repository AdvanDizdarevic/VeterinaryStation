using System.ComponentModel.DataAnnotations;

namespace VeterinaryStation.Areas.ModulAdmin.Models
{
    public class PodaciAddVM
    {
        [Required(ErrorMessage = "Obavezno polje")]
        public string Naziv { get; set; }
    }
}