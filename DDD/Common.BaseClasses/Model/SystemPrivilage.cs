using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.SharedData.Model.Enums;

namespace Common.BaseClasses.Model
{
    internal class SystemPrivilage
    {
        [Key]
        public SystemPrivilages PrivilageName { set; get; }
        public ICollection<User> Users { set; get; } 
    }
}
