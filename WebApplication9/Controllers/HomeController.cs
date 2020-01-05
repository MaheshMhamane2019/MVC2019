
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;
using System.Data;
namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        maheshEntities mdb = new maheshEntities();
        // GET: Home
        public ActionResult Index()
        {
            ViewData["countries"] = new List<string>
            {
                "Pune","Mumbai","Klkata","Panhi","Pout","Sangola"
            };
            Employee emp = new Employee();
            emp.id = 1;
            emp.Name = "ABS";
           // mdb.tblStudents.Add(emp.id= 1, emp.Name="",emp.Gender="M",emp.Did=1);
           // mdb.SaveChanges();
            return View();
        }

        public ActionResult GetData()

        {
            Employee emp = new Employee();
            emp.id = 11;
            emp.Name = "Mahesh";
            emp.Gender = "Male";

            return View(emp);

        }
       
    }
}