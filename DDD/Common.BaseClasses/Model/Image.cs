using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.BaseClasses.Model
{
    internal class Image
    {
        [Key,Column(Order = 1)]
        public int EventId { set; get; }
        [ForeignKey(nameof(EventId))]
        public virtual CenterEvent Event { set; get; }
        public Guid Location { get; protected set; }

        public string ImageDescription { set; get; }
    }
}
