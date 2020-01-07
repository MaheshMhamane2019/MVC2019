using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using WebApplication9.Models;


namespace WebApplication9.Models
{
    public class StudentsContext: System.Data.Entity.DbContext
    {
        public DbSet<Student> Students  { get; set; }
        public DbSet<Departmnet> Departmnets { get; set; }


    }
}