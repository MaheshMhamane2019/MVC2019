﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication9.Models
{
   [ Table("tblStudents")]
    public class Student
    {   
        public int ID { get; set; }
        public String Name { get; set; }
        public String Gender { get; set; }
        public int TotalMarks { get; set; }
        public int DepartmentId { get; set; }
    }
}