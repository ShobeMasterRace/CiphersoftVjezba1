using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Ciphersoft_Vjezba
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

    }

    public class BlogDbContext : DbContext
    {
        public DbSet<Department> Lista { get; set; }

    }


    class Program
    {
        static void Main(string[] args)
        {
            BlogDbContext BDC = new BlogDbContext();

            List<Department> Depts = BDC.Lista.ToList();

            Department D = new Department { Name = "Danilo", Surname = "Simeunovic" };
            BDC.Lista.Add(D);

            BDC.SaveChanges();
        }
    }
}
