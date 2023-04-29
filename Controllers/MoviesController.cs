using CineRent.Models;
using System.Web.Mvc;

namespace CineRent.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Rapunzel" };
            return View(movie);
        }
    }
}