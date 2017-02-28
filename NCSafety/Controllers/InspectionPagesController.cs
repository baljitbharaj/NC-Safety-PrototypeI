using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NCSafety.Controllers
{
    [Authorize]
    public class InspectionPagesController : Controller
    {
        // GET: InspectionPages
        public ActionResult NewInspection()
        {
            return View();
        }

        public ActionResult EditInspection()
        {
            return View();
        }

        public ActionResult ListInspection()
        {
            return View();
        }

        public ActionResult ViewInspection()
        {
            return View();
        }

        public ActionResult DraftInspection()
        {
            return View();
        }
    }
}