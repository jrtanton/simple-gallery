using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleGallery.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail()
        {

            if (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
            {
                return Redirect("/");
            }

            return Content("Wecome to the comic book page.");
            
        }
    }
}