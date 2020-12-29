using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VeterinaryStation.Models;

namespace VeterinaryStation.Areas.ModulTehnickoOsoblje.Models
{
    public class Uloga
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public string NazivUloge { get; set; }

        public List<Uloge> listaUloga { get; set; }
        public int UlogeId { get; set; }


    }
}