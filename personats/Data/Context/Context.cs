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
    }
}