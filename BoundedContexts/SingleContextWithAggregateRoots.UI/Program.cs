using DomainClasses.Model;
using SingleContextWithAggregateRoots.DataLayer.Context;
using System;

namespace SingleContextWithAggregateRoots.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SingleContextWithAggrgateRootsContext context =
                new SingleContextWithAggrgateRootsContext())
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
