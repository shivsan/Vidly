using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    [RoutePrefix("movies")]
    public class MoviesController : Controller
    {
        // GET: Movies
        //public ActionResult Index()
        //{
        //    return View();
        //}
        
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (pageIndex.HasValue)
                pageIndex = 1;

            return Content(string.Format("{0}{1}", pageIndex, sortBy));
        }

        [Route("releases/{year:regex(\\d{4})}/{genre:regex(\\w+)}")]
        public ActionResult ByRelease(int year, string genre)
        {
            ViewBag.Title = "";
            ViewData[""] = "";
            ViewData["faf"] = "";
            return Content(string.Format("{0} {1}", year, genre));
        }

        public ActionResult Edit(int id)
        {
            return Content("id="+id);
        }

        public ActionResult Random()
        {
            var movie = new Movie { Id = 1, Name = "Shrek" };
            dynamic dyn = new System.Dynamic.ExpandoObject();
            dyn.f = "";
            ViewData["title"] = "big";
            return View(movie);
            //return new ViewResult();
        }

        public ActionResult HalfMovie()
        {
            var movie = new Movie { Id = 1, Name = "Shrek" };
            return PartialView(movie);
            //return new ViewResult();
        }

        public JsonResult GetData()
        {
            return new JsonResult();
        }

        public HttpNotFoundResult Nothing()
        {
            return new HttpNotFoundResult();
        }

        public ContentResult Cont()
        {
            return new ContentResult() { Content = "Shrekking" };
        }

    }
}