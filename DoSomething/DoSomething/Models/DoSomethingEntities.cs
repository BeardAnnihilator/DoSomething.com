using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DoSomething.Models
{
    public class DoSomethingEntities : DbContext
    {
        public DoSomethingEntities()
            : base("DoSomethingEntities")
        {
        }

        public DbSet<User> Users { get; set; }
    }
}