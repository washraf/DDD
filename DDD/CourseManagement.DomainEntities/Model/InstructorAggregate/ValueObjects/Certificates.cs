using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CourseManagement.DomainEntities.Model.InstructorAggregate.ValueObjects
{
    public class Certificates
    {
        public Certificates(string name, DateTime date, DateTime expireDate)
        {
            Name = name;
            Date = date;
            ExpireDate = expireDate;
        }
        public string Name { get;private set; }
        public DateTime Date { get; private set; }
        public DateTime ExpireDate { get;private set; }
    }
}
