﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VeterinaryStation.Areas.ModulDoktor.Controllers
{
    public class DoktorController : Controller
    {
        // GET: ModulDoktor/Doktor
        public ActionResult Home()
        {
            return View();
        }
    }
}