using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Ciphersoft_Vjezba
{
    public class BlogDbContext : DbContext 
    {
        public BlogDbContext() : base()
        {



        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=Test; Trusted_Connection=true");
            //Server = lokacija servera, nalazi se u SQL Server Explorer (upper left corner), Database = Odabrat bazu podataka u ovom slučaju se zove "Test", Trusted Connenction = true da ne treba password
        }


        //Liste baze podataka
        public DbSet<Department> Lista { get; set; }
        public DbSet<Adresa> Adrese { get; set; }

    }   

}
