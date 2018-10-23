/*Ross Rosenlof Oct 23, 2018*/

using RoseLeaf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoseLeaf_Recruiting.Controllers
{
    public class HomeController : Controller
    {
        public static List<Student> listStudents = new List<Student>();


        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SignUpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult SignUpForm(Student student)
        {
            if (ModelState.IsValid)
            {
                listStudents.Add(student);
                return View("ThankYou", student);
            }
            else
            {
                //Validation Error
                return View();
            }
        }

        public ActionResult Display()
        {
            ViewBag.Results = listStudents;
            return View();
        }
    }
}