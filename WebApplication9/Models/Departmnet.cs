using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication9.Models
{   [Table("tblDepartment")]
    public class Departmnet
    {
        public int ID { get; set; }

        public String Name { get; set; }
        List<Student> Students { get; set; }
    }
}