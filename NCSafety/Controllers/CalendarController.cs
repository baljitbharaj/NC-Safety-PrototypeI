﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NCSafety.Controllers
{
    [Authorize]
    public class CalendarController : Controller
    {
        // GET: Calendar
        public ActionResult Calendar()
        {
            return View();
        }
    }
}