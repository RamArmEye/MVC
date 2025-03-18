using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentsMVC.Models;


namespace StudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page - Academy of Learning.";

            return View();
        }
        public ActionResult Instructor(int id)
        { 
            ViewBag.Id = id;

            Instructor dayTimeInstructors = new Instructor
            {
                Id = 1,
                FirstName = "Erik",
                LastName = "Gross"
            };

            return View();
        }

        public ActionResult Instructors()
        {     
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    Id = 1,
                    FirstName = "Erik",
                    LastName = "Gross"
                },
                new Instructor
                {
                    Id = 2,
                    FirstName = "John",
                    LastName = "Doe"
                },
                new Instructor
                {
                    Id = 3,
                    FirstName = "Jane",
                    LastName = "Doe"
                }
            };

            return View(instructors);
        }
    }
}