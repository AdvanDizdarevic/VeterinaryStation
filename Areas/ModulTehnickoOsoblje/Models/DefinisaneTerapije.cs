﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VeterinaryStation.Models;

namespace VeterinaryStation.Areas.ModulTehnickoOsoblje.Models
{
    public class DefinisaneTerapije
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public int Doziranje { get; set; }

        public List<Pregledi> listaPregleda { get; set; }
        public int PreglediId { get; set; }

        public List<Terapija> listaTerapija { get; set; }

        public int TerapijaId { get; set; }

        public List<DefinsanaTerapija> listaDefinisanihTerapija { get; set; }
        public int DefinisanaTerapijaId { get; set; }
    }
}