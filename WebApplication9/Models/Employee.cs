﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication9.Models
{
    [Table("Employee")]
    public class Employee
    {
       
                public int EmployeeId { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public string City { get; set; }
        
    }
}