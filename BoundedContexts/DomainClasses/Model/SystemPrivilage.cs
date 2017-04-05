using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Model.Enums;

namespace DomainClasses.Model
{
    public class SystemPrivilage
    {
        [Key]
        public SystemPrivilages PrivilageName { set; get; }
        public ICollection<User> Users { set; get; } 
    }
}
