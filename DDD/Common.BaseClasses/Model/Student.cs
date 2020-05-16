﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.BaseClasses.Model
{
    [Table(nameof(Student))]
    internal class Student:User
    {
        public virtual ICollection<StudentSubcription> StudentSubcriptions { set; get; }
    }
}
