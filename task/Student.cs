﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    
        public class Student
    {
        [Key]
        public int Id { get; set; }
            public string Name { get; set; }
        public string Email { get; set; }
        public List<Enrollment> cource { get; set; }

        }
    
}
