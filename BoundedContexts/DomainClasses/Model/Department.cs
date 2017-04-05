using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainClasses.Model
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentId { set; get; }

        public string DepartmentName { set; get; }

        public virtual ICollection<Employee> Employees { set; get; }

    }
}