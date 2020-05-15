using DomainClasses.Model;
using SingleContext.DataLayer.Context;
using System;

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
