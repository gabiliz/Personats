using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using personats.Data.Entity;

namespace personats.Data.Context
{
    public class Context : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Enterprise> Enterprises { get; set; }
        public DbSet<Opportunity> Opportunities { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Graduation> Graduations { get; set; }
        public DbSet<Recruiter> Recruiters { get; set; }
        public DbSet<Sexuality> Sexualities { get; set; }
    }
}