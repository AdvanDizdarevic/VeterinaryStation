using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VeterinaryStation.Areas.ModulLogin.Models
{
    public class LoginViewModel
    {
        
        public string Username { get; set; }

        [Required(ErrorMessage = "Unos je obavezan za Password polje!")]
        public string Password { get; set; }

        public  string PotvrdaUsername { get; set; }

        public bool Status { get; set; }
    }
}