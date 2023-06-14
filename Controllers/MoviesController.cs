using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Index
        public ActionResult Index()
        {
            //var movie = new Movie() { Name="!Shrek"};
            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;
            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model;

            //[Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
            //public ActionResult ByReleaseDate(int year, int month)
            //{
            //    return Content(year+"/"+month);
            //}

            //var customers = new List<Customer>
            //{ new Customer{ Name = "Customer 1"}, new Customer{ Name ="Customer 2"} };

            //var viewModel = new RandomMovieViewModel
            //{ 
            //Movie = movie,
            //Customers = customers
            //};
            //return View(viewModel);

           
            return View(GetMovies());
        }

        public List<Movie>GetMovies() 
        {
            return new List<Movie> { new Movie { Id = 0, Name = "Shrek" }, new Movie { Id = 1, Name = "Titanic" } };
           
        }

        public ActionResult Details(int id)
        {

            return View(GetMovies().SingleOrDefault(c=>c.Id==id));
        }
        
    }
}