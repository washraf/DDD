using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement.DomainEntities.Model
{
    [Table("Employees")]
    public class Employee : User
    {
        public Department MainDepartment { set; get; }
        public decimal FixedSalary { set; get; }
        public void SignIn()
        {

        }
        public void SignOut()
        {

        }
    }
}
