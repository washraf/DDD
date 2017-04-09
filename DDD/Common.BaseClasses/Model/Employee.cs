using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.BaseClasses.Model;

namespace Common.BaseClasses.Model
{
    [Table("Employees")]
    internal class Employee:User
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
