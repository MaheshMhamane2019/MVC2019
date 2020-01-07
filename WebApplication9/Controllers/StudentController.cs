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
        //GET: Student
        public ActionResult Details1(int ID)
        {
           
                StudentsContext studentcontext = new StudentsContext();
                Student std = studentcontext.Students.Single(std1 => std1.ID == ID);

                return View(std);
            
        }

        public ActionResult Details2(int ID)
        {

            StudentsContext studentcontext = new StudentsContext();
            List<Student> std = studentcontext.Students.Where(std1 => std1.DepartmentId == ID).ToList();

            return View(std);

        }
        public ActionResult Index()
        {

            StudentsContext studentcontext = new StudentsContext();
            List<Student> students = studentcontext.Students.ToList();

            return View(students);

        }
        //public ActionResult StdList(int Id)
        //{

        //    StudentsContext studentcontext = new StudentsContext();
        //    List<Student> Students = studentcontext.Students.Where(std1 => std1.DepartmentId == Id).ToList();
        //   // List<Student> Students = studentcontext.Students.ToList();

        //    return View(Students);

        //}
        public ActionResult Dept()
        {

            StudentsContext studentcontext = new StudentsContext();
            List<Departmnet> dept = studentcontext.Departmnets.ToList();

            return View(dept);

        }

    }
}