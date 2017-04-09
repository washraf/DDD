using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Site.DomainEntities.Model
{
    public class CenterEvent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int EventId { set; get; }
        public DateTime Date { set; get; }
        public string Desciption { set; get; }
        public string Agenda { set; get; }
        public virtual ICollection<Image> Images { set; get; }
    }
}
