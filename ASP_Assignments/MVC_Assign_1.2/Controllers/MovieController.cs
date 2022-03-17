using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Assign_1._2.Models;

namespace MVC_Assign_1._2.Controllers
{

    public class MovieController : Controller
    {
        MoviedatabaseEntities1 movie_db = new MoviedatabaseEntities1();
        // GET: Movie
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyMovieScaffolded()
        {
            List<Movietable> mvlist = movie_db.Movietables.ToList();
            return View(mvlist);
        }

        //create
        [HttpGet]
        public ActionResult Create()
        {​
               return View();
        }​​

        [HttpPost]
        public ActionResult Create(Movietable mvlist)
        {​​
            movie_db.Movietables.Add(mvlist);
            movie_db.SaveChanges();
            return RedirectToAction("MyMovieScaffolded");
        }​​ 
        public ActionResult Details(int id)
        {​​
            Movietable mvlist = movie_db.Movietables.Find(id);
            return View(mvlist);
        }​​
        //Edit
        [HttpGet]
        public ActionResult Edit(int id)
        {​​
            Movietable mvlist = movie_db.Movietables.Find(id);
            return View(mvlist);
        }​​
        
        [HttpPost]
        public ActionResult Edit(Movietable movietable)
        {​​
            Movietable m = movie_db.Movietables.Find(movietable.mid);
            m.moviename = movietable.moviename;
            m.dateofrelease = movietable.dateofrelease;
            movie_db.SaveChanges();
            return RedirectToAction("MyMovieScaffolded");
        }​​ 
        
        //Delete
        public ActionResult Delete(int id)
        {​​
            Movietable mvlist = movie_db.Movietables.Find(id);
            movie_db.Movietables.Remove(mvlist);
            movie_db.SaveChanges();
            return RedirectToAction("MyMovieScaffolded");
        }​​



    }
}