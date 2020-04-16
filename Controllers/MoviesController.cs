using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            return View(movie);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2})}")]

        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content( year + "/" + month);
        }
    }
}