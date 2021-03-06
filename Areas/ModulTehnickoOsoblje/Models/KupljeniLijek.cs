﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VeterinaryStation.Models;

namespace VeterinaryStation.Areas.ModulTehnickoOsoblje.Models
{
    public class KupljeniLijek
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public int Kolicina { get; set; }

        public List<Racuni> listaRacuna { get; set; }
        public int RacuniId { get; set; }

        public List<Lijekovi> listaLijekova { get; set; }

        public int LijekoviId { get; set; }

        public List<KupljeniLijekovi> listaKupljenihLijekova { get; set; }

        public int KupljeniLijekoviId { get; set; }

    }
}