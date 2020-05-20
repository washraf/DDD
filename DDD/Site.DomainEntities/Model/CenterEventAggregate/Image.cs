using Common.Utils.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.DomainEntities.Model
{
    public class Image : Entity
    {
        public int EventId { set; get; }
        [ForeignKey(nameof(EventId))]
        public virtual CenterEvent Event { set; get; }
        public Guid Location { get; protected set; }

        public string ImageDescription { set; get; }

        public override bool IsValid => true;

        public override Dictionary<string, string> ValidationErrors => new Dictionary<string, string>();
    }
}
