using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
        
            // return View(movie);
            // return Content("Hello World!");
            // return NotFound();
            // return new EmptyResult();
            return RedirectToAction("Index", "Home", new {page=1, sortBy="EssaBarbar"});
        }

    }
}
