using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {

            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the final hour lourem ipsem.......";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Author: Humberto Ramos",
                "Inks: Victor Olazabo"
            };

            return View();
        }
    }
}