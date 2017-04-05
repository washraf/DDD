using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Model;
using SingleContext.DataLayer.Context;

namespace SingleContext.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (OldSingleContext context = new OldSingleContext())
            {
                context.Users.Add(new Student()
                {
                    Address = "Address",
                    BirthDate = DateTime.Now,
                    Name = "Walid",
                    Phone = "0100"
                });
                context.SaveChanges();
            }
        }
    }
}
