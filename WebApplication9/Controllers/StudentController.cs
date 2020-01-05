using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Details(int ID)
        {
            StudentsContext studentcontext = new StudentsContext();
            Student std = studentcontext.Students.Single(std1 => std1.ID==ID);

            return View(std);
        }
    }
}