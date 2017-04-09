using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Common.SharedData.Model.Enums;

namespace Site.DomainEntities.Model
{
    public class SystemPrivilage
    {
        [Key]
        public SystemPrivilages PrivilageName { set; get; }
        public ICollection<User> Users { set; get; }
    }
}