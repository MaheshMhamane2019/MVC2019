
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["countries"] = new List<string>
            {
                "Pune","Mumbai","Klkata","Panhi","Pout","Sangola"
            };


            return View();
        }

        public ActionResult GetData()

        {
            Employee emp = new Employee();
            emp.EmployeeId = 11;
            emp.Name = "Mahesh";
            emp.Gender = "Male";

            return View(emp);

        }
       
    }
}