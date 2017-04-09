using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utils.Repository.Exceptions
{
    public class DbSetNotFoundException:Exception
    {
        public string SetName { protected set; get; }
        public DbSetNotFoundException(string messge, string setName):base(messge)
        {
            SetName = setName;
        }
    }
}
