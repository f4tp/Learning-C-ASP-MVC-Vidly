using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlySept2018.Models;

namespace VidlySept2018.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var ranMovie = new Movie(){Name = "Shrek!", Id = 1};
            
            //return View(ranMovie); //passes Movie Model to view
            //return Content("Hello World"); //overwrites content
            return HttpNotFound("not found error here");
        }
    }
}