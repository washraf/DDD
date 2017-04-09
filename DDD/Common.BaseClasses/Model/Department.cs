using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Common.BaseClasses.Model;

namespace Common.BaseClasses.Model
{
    internal class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentId { set; get; }

        public string DepartmentName { set; get; }

        public virtual ICollection<Employee> Employees { set; get; }

    }
}